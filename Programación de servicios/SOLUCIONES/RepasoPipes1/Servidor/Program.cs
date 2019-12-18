using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Pipes;
using System.IO;
using Mensajes;
using System.Diagnostics;
namespace Servidor
{
    class Program
    {
        static void Main(string[] args)
        {    /*Registra el mensaje*/
            string STR_WM_INFO = "WM_INFO";
            string nombre;
            int caracteres,cont;
            float longmedia;

            int WM_INFO = Funciones.RegisterWindowMessage(STR_WM_INFO);
            /*Crea dos pipes con nombre.
             * Uno para conectarse con en formulario y 
             * otro para conectarse con el Cliente(PipeForm y PipeCli).
             * En el primero solo escribirá datos y 
             * en el segundo podrá tanto leer como escribir.*/
            using (NamedPipeServerStream npss=new NamedPipeServerStream("srvfrm",PipeDirection.Out))
            {
                npss.WaitForConnection();
                StreamWriter sw = new StreamWriter(npss);
                sw.AutoFlush = true;
                using (NamedPipeServerStream npssc = new NamedPipeServerStream("srvcli", PipeDirection.InOut))
                {
                    npssc.WaitForConnection();
                    StreamWriter swc = new StreamWriter(npssc);
                    swc.AutoFlush = true;
                    StreamReader sr = new StreamReader(npssc);
                    //Enviará al cliente la palabra “File ?”
                    swc.WriteLine("File?");
                    nombre = sr.ReadLine();
                    StreamWriter swf = new StreamWriter(nombre);
                    swc.WriteLine("Next");
                    String linea = sr.ReadLine();
                    caracteres = 0;
                    cont = 0;
                    while (linea.CompareTo("EOF") != 0)
                    {
                        cont++;
                        caracteres += linea.Length;

                        swf.WriteLine(linea);
                        swc.WriteLine("Next");
                        linea = sr.ReadLine();
                    }
                    swf.Close();
                    
                    longmedia=caracteres/cont;

                    }
                IntPtr handle =Process.GetProcessesByName("RepasoPipes1")[0].MainWindowHandle;
                Funciones.PostMessage(handle, WM_INFO, IntPtr.Zero, IntPtr.Zero);
                sw.WriteLine(nombre);
                sw.WriteLine(caracteres.ToString());
                sw.WriteLine(longmedia.ToString());
                }
            Console.ReadLine();
            }
        }
    }

