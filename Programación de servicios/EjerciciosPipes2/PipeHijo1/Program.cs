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
            int num;
            using (AnonymousPipeClientStream apcs = new AnonymousPipeClientStream(PipeDirection.In, args[0]))
            {
                using (StreamReader sr = new StreamReader(apcs))
                {
                    i = Int32.Parse(sr.ReadLine());
                    num = Int32.Parse(sr.ReadLine());
                }
                using (StreamWriter sw = new StreamWriter(apcs))
                {
                    Console.WriteLine("Yo soy el hijo {0}, con el PID {1}", i, num);
                }
            }
        }
    }
}
