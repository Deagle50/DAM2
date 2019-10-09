using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Windows;
using System.Diagnostics;

namespace PipeHijo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            //int pid1;
            //int pid2;
            using (AnonymousPipeClientStream apcs = new AnonymousPipeClientStream(PipeDirection.In, args[0]))
            {
                using (StreamReader sr = new StreamReader(apcs))
                {
                    i = Int32.Parse(sr.ReadLine());
                    
                }
                using (StreamWriter sw = new StreamWriter(apcs))
                {
                    Console.WriteLine("Yo soy el hijo {0}", i);
                }
            }
        }
    }
}
