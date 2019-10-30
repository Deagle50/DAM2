using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;

namespace PipeHijo2
{
    class Program
    {
        static void Main(string[] args)
        {
            String pal;
            NamedPipeClientStream npcs = new NamedPipeClientStream(".", "EjercicioPipes5", PipeDirection.In);
            StreamReader sr = new StreamReader(npcs);

            npcs.Connect();
            Console.WriteLine("Conexión aceptada");
            pal=sr.ReadLine().ToString();

            while (pal.ToLower().CompareTo("fin") != 0) {
                Console.WriteLine(pal);
                pal = sr.ReadLine();
            }
        }
    }
}
