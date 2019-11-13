using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Pipes;
using System.IO;

namespace Hijo1
{
    class Program
    {
        static void Main(string[] args)
        {
            NamedPipeServerStream npss = new NamedPipeServerStream("pipes5", PipeDirection.Out);
            npss.WaitForConnection();
            StreamWriter sw = new StreamWriter(npss);
            Console.WriteLine("Conexión Entrante");
            Console.WriteLine("Introduce palabra");
            String pal = Console.ReadLine();
            sw.AutoFlush = true;
            while(pal.ToLower().CompareTo("fin")!=0)
            {
                sw.WriteLine(pal);
                Console.WriteLine("Introduce palabra");
               pal = Console.ReadLine();
            }
            sw.WriteLine(pal);
            npss.WaitForPipeDrain();
            npss.Close();
        }
    }
}
