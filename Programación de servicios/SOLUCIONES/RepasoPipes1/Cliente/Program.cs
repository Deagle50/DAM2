using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Pipes;
using System.IO;
namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            using (NamedPipeClientStream npcs = new NamedPipeClientStream(".", "srvcli", PipeDirection.InOut))
            {
                npcs.Connect();
                StreamWriter sw = new StreamWriter(npcs);
                sw.AutoFlush = true;
                StreamReader sr = new StreamReader(npcs);
                String pal = sr.ReadLine();
                Console.WriteLine(pal);
                Console.WriteLine("INtroduce el nombre del fichero: ");
                String nombre = Console.ReadLine();
                
                sw.WriteLine(nombre);
                StreamReader srf = new StreamReader(nombre);
                pal = sr.ReadLine();
                Console.WriteLine(pal);
                pal = srf.ReadLine();
                while(pal!=null)
                {
                    sw.WriteLine(pal);
                    pal = sr.ReadLine();
                    Console.WriteLine(pal);
                    pal = srf.ReadLine();
                }
                sw.WriteLine("EOF");
            }
            Console.ReadLine();
        }
    }
}
