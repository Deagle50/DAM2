//PADRE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;

namespace NamedPipesExc
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            using (NamedPipeServerStream npss = new NamedPipeServerStream("NamedPipesEx", PipeDirection.InOut))
            {
                using (StreamReader sr = new StreamReader(npss))
                {
                    using (StreamWriter sw = new StreamWriter(npss))
                    {
                        npss.WaitForConnection();
                        sw.AutoFlush = true;                        
                        Console.WriteLine("Conexión entrante.");
                        String pal = sr.ReadLine().ToString();
                        
                        while (pal.ToUpper().CompareTo("FIN") != 0)
                        {
                            Console.WriteLine(pal);
                            String respuesta = Console.ReadLine();
                            sw.WriteLine(respuesta);
                            pal = sr.ReadLine();
                            cont++;
                        }
                    }
                }
                
            }
            Console.WriteLine("Se han enviado {0} palabras", cont.ToString());
            Console.ReadLine();
        }
    }
}
