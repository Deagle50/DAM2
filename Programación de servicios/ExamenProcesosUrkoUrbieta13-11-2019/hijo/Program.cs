using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;

namespace hijo
{
    class Program
    {
        static void Main(string[] args)
        {
            NamedPipeClientStream npcs;
            StreamWriter sw;
            StreamReader sr;
            String opcion;
            
            
            npcs = new NamedPipeClientStream(".", "server", PipeDirection.InOut);
            npcs.Connect();
            sw = new StreamWriter(npcs);
            sr = new StreamReader(npcs);            
            sw.AutoFlush = true;

            leerMenu(sr, sw);
            opcion = sr.ReadLine();
            hacerOpcion(opcion, sw, sr);
            while (opcion != "salir")
            {
                leerMenu(sr, sw);
                opcion = sr.ReadLine();
                hacerOpcion(opcion, sw, sr);
            }
            npcs.WaitForPipeDrain();
            npcs.Close();
        }
        static void leerMenu(StreamReader sr, StreamWriter sw) {
            String[] menu = new String[4];
            String o;
            int opc=0;
            menu[0] = sr.ReadLine();
            menu[1] = sr.ReadLine();
            menu[2] = sr.ReadLine();
            menu[3] = sr.ReadLine();

            Console.Clear();

            do
            {
                
                for (int i = 0; i < 4; i++)
                    Console.WriteLine(menu[i]);
                Console.WriteLine("Escribe un número");
                o=Console.ReadLine();
                while (!int.TryParse(o,out opc)) {
                    Console.WriteLine("Escribe un número");
                    o = Console.ReadLine();
                }
                Console.Clear();
            } while(opc<0||opc>4);

            sw.WriteLine(opc);
        }

        static void hacerOpcion(String opcion, StreamWriter sw, StreamReader sr)
        {
            int max, num;
            if (opcion == "cargando")
            {
                Console.WriteLine("cargando");
                Console.WriteLine("Escribe un límite de números");
                max = int.Parse(Console.ReadLine());
                sw.WriteLine(max);
                for (int i = 0; i < max; i++)
                {
                    num = int.Parse(Console.ReadLine());
                    sw.WriteLine(num);
                }
                Console.WriteLine("números enviados, pulse una tecla para continuar");
                Console.ReadLine();
            }
            else if (opcion == "pares")
            {
                Console.WriteLine("pares");
                num = int.Parse(sr.ReadLine());
                while (num != -1)
                {
                    Console.WriteLine(num);
                    num = int.Parse(sr.ReadLine());
                }
                Console.WriteLine("números pares mostrados, pulse una tecla para continuar");
                Console.ReadLine();
            }
            else if (opcion == "impares")
            {
                Console.WriteLine("impares");
                num = int.Parse(sr.ReadLine());
                while (num != -1)
                {
                    Console.WriteLine(num);
                    num = int.Parse(sr.ReadLine());
                }
                Console.WriteLine("números impares mostrados, pulse una tecla para continuar");
                Console.ReadLine();
            }
            else if (opcion == "error")
            {
                Console.WriteLine("Error, carga el array primero");
                Console.ReadLine();
            }
            else if (opcion == "salir") {
                Console.WriteLine("Saliendo del programa, pulse una tecla para continuar");
                Console.ReadLine();
            }
        }
    }
}
