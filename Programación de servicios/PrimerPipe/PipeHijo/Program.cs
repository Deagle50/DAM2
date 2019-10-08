using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;

namespace PipeHijo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AnonymousPipeClientStream apcs = new AnonymousPipeClientStream(PipeDirection.Out, args[0]))
            {
                using (StreamWriter sw = new StreamWriter(apcs))
                {
                    sw.AutoFlush = true;

                    ConsoleKey car = ConsoleKey.A;
                    do
                    {
                        if (Console.KeyAvailable)
                        {                            
                            ConsoleKeyInfo cki = Console.ReadKey();
                            car = cki.Key;
                            sw.Write(cki.KeyChar);
                            Console.Write(cki.KeyChar);
                        }
                    } while (car != ConsoleKey.Escape);
                    sw.Write('*');
                }
            }
        }
    }
}
