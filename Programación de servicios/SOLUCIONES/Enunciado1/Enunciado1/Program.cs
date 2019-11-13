using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
namespace Enunciado1
{
    class Program
    {
        static void Main(string[] args)
        {
            NamedPipeServerStream npss = new NamedPipeServerStream("Enunciado1", PipeDirection.InOut);
            npss.WaitForConnection();
            StreamWriter sw = new StreamWriter(npss);
            sw.AutoFlush = true;
            StreamReader sr = new StreamReader(npss);
            int x, y;
            Console.WriteLine("Introduce X: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce Y: ");
            y = int.Parse(Console.ReadLine());
            sw.WriteLine(x);
            sw.WriteLine(y);
            String pal = PedirPalabra();
            while (pal.CompareTo("fin") != 0)
            {
                sw.WriteLine(pal);
                 pal = PedirPalabra();
            }
            sw.WriteLine("fin");
            x = int.Parse(sr.ReadLine());
            y = int.Parse(sr.ReadLine());
            Console.WriteLine("El objeto está en {0},{1}", x.ToString(), y.ToString());
            npss.Close();
            Console.ReadLine();
        }

        private static string PedirPalabra()
        {
            Console.WriteLine("Palabra: ");
            String pal = Console.ReadLine().ToLower();
            while(pal.CompareTo("fin")!=0&&pal.CompareTo("up")!=0&&pal.CompareTo("down")!=0&&pal.CompareTo("right")!=0&&pal.CompareTo("left")!=0)
            {
                Console.WriteLine("Palabra incorrecta \nPalabra: ");
                pal = Console.ReadLine().ToLower();
            }
            return pal;
        }
    }
}
