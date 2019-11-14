using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;

namespace ExamenProcesosUrkoUrbieta13_11_2019
{
    class Program
    {
        public static int[] nums;
        public static bool inicializado = false;
        static void Main(string[] args)
        {
            NamedPipeServerStream npss;
            StreamWriter sw;
            StreamReader sr;
            int opc;
              
            npss = new NamedPipeServerStream("server", PipeDirection.InOut);
            npss.WaitForConnection();

            sw = new StreamWriter(npss);
            sr = new StreamReader(npss);
            sw.AutoFlush = true;

            enviarMenu(sw);
            opc=int.Parse(sr.ReadLine());
            enviarOpcionMenu(opc, sw, sr);
            while (opc != 4)
            {
                enviarMenu(sw);
                opc = int.Parse(sr.ReadLine());
                enviarOpcionMenu(opc, sw, sr);
            }
            npss.Close();
            //Console.ReadLine();
        }

        static void enviarMenu(StreamWriter sw) {            
            sw.WriteLine("1.Cargar tabla");
            sw.WriteLine("2.Ver pares");
            sw.WriteLine("3.Ver impares");
            sw.WriteLine("4.Salir");
        }

        static void enviarOpcionMenu(int opc, StreamWriter sw, StreamReader sr) {
            int max;            
            switch (opc)
            {
                case 1:                    
                    sw.WriteLine("cargando");
                    max=int.Parse(sr.ReadLine());
                    nums = new int[max];
                    for(int i = 0;i< max;i++)
                        nums[i] = int.Parse(sr.ReadLine());
                    inicializado = true;
                    break;
                    
                case 2:
                    if (!inicializado)
                    {
                        error(sw);
                        break;
                    }
                    sw.WriteLine("pares");
                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] % 2 == 0)
                            sw.WriteLine(nums[i]);
                    }
                    sw.WriteLine(-1);
                    break;
                case 3:
                    if (!inicializado)
                    {
                        error(sw);
                        break;
                    }
                    sw.WriteLine("impares");
                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] % 2 == 1)
                            sw.WriteLine(nums[i]);
                    }
                    sw.WriteLine(-1);
                    break;
                case 4:
                    sw.WriteLine("salir");
                    break;
            }
                
        }

        static void error(StreamWriter sw) {
            sw.WriteLine("error");
        }
    }
}
