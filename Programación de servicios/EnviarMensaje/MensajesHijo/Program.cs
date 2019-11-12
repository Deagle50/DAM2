using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using Funciones;
using System.Diagnostics;

namespace MensajesHijo
{
    class Program
    {
        static void Main(string[] args)
        {
            int WM_MENSAJE = Funciones.Funciones.RegisterWindowMessage("WM_MENSAJE");
            String pal;
            IntPtr h;
            //COMPROBAR ARGUMENTOS
            NamedPipeClientStream npcs = new NamedPipeClientStream(".", "MensajePipe", PipeDirection.Out);
            StreamWriter sw = new StreamWriter(npcs);
            Process p  = Process.GetProcessesByName("EnviarMensaje")[0]; ;
            npcs.Connect();
            sw.AutoFlush = true;
            Console.WriteLine("Palabra: ");
            pal = Console.ReadLine();
            h = p.MainWindowHandle;
            while (pal.ToLower().CompareTo("fin") != 0)
            {
               
                //p = Process.GetProcessesByName("Enviar mensaje")[0];
                h = p.MainWindowHandle;
                Funciones.Funciones.PostMessage(h, WM_MENSAJE, IntPtr.Zero, IntPtr.Zero);
                sw.WriteLine(pal);
                Console.WriteLine("palabra: ");
                pal = Console.ReadLine();
            }
            Funciones.Funciones.PostMessage(h, WM_MENSAJE, IntPtr.Zero, IntPtr.Zero);
            sw.WriteLine("Fin");
            npcs.Close();

        }
    }
}
