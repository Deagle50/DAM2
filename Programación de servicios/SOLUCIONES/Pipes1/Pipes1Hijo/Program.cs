using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Pipes;
using System.IO;
using System.Diagnostics;
namespace Pipes1Hijo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AnonymousPipeClientStream apcs=new AnonymousPipeClientStream(PipeDirection.In,args[0]))
            {
                using(StreamReader sr=new StreamReader(apcs))
                {
                    int num=int.Parse(sr.ReadLine());
                    num -= 4;
                    Console.WriteLine("PID {0} Número {1}", Process.GetCurrentProcess().Id, num);
                    Console.ReadLine();
                }
            }
        }
    }
}
