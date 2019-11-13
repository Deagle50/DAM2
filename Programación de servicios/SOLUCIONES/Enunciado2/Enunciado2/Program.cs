using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
namespace Enunciado2
{
    class Program
    {
        static void Main(string[] args)
        {
            NamedPipeServerStream npss = new NamedPipeServerStream("Enunciado2", PipeDirection.InOut);
            npss.WaitForConnection();
            StreamReader sr = new StreamReader(npss);
            StreamWriter sw = new StreamWriter(npss);
            sw.AutoFlush = true;
            float db, hb,importe;
            Console.WriteLine("DEbe: ");
            db = float.Parse(Console.ReadLine());
            Console.WriteLine("Haber: ");
            hb = float.Parse(Console.ReadLine());
            sw.WriteLine(db);
            sw.WriteLine(hb);
            String pal = LeerPalabra();
            while(pal.CompareTo("fin")!=0)
            {
                Console.WriteLine("Importe: ");
                importe = float.Parse(Console.ReadLine());
                sw.WriteLine(pal);
                sw.WriteLine(importe);
                pal = LeerPalabra();
            }
            sw.WriteLine("fin");
            db = float.Parse(sr.ReadLine());
            hb = float.Parse(sr.ReadLine());
            Console.WriteLine("Saldo: {0}", db - hb);
            npss.Close();
            Console.ReadLine();
        }

        private static string LeerPalabra()
        {
            Console.WriteLine("Operación: ");
            String pal = Console.ReadLine();
            return pal;
        }
    }
}
