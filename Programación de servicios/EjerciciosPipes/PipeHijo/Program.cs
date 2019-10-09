using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.IO.Pipes;

namespace PipeHijo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            using (AnonymousPipeClientStream apcs = new AnonymousPipeClientStream(PipeDirection.In, args[0]))
            {
                using (StreamReader sr = new StreamReader(apcs))
                {
                    i=Int32.Parse(sr.ReadLine());
                    Console.Write(i-4);
                    
                    
                }
            }
            Console.ReadLine();
        }
    }
}
