using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;


namespace PipeHijo1
{
    class Program
    {
        static void Main(string[] args)
        {
            String pal;
            NamedPipeServerStream npss = new NamedPipeServerStream("EjercicioPipes5", PipeDirection.Out);
            StreamWriter sw = new StreamWriter(npss);
            
            npss.WaitForConnection();
            Console.WriteLine("Conexión entrante");
            Console.WriteLine("Escriba una palabra");
            pal = Console.ReadLine();
            sw.AutoFlush = true;
            while (pal.ToLower().CompareTo("fin") != 0){
                sw.WriteLine(pal);
                Console.WriteLine("Introduce una palabra");
                pal = Console.ReadLine();
            }
            sw.WriteLine(pal);
            npss.WaitForPipeDrain();
            npss.Close();
            
        }
    }
}
