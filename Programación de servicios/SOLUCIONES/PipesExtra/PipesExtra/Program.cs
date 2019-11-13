using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.IO.Pipes;
namespace PipesExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AnonymousPipeServerStream apsi=new AnonymousPipeServerStream(PipeDirection.In,HandleInheritability.Inheritable))
            {
                using (StreamWriter sw = new StreamWriter(apsi))
                {

                    int num;
                    Console.WriteLine("INtroduce un número");
                    num = int.Parse(Console.ReadLine());
                    sw.AutoFlush = true;
                    while (num!=0)
                    {
                        sw.WriteLine(num);
                        Console.WriteLine("INtroduce un número");
                        num = int.Parse(Console.ReadLine());
                    }
                }
        }
    }
}
