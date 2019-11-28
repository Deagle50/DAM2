using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Pipes;
using System.IO;
using System.Diagnostics;

namespace Auricular
{
    class Program
    {
        static void Main(string[] args)
        {
            NamedPipeClientStream npcs;
            NamedPipeServerStream npssa;
            StreamReader sr;
            StreamWriter sw;
            string mensaje;

            //npssa = new NamedPipeServerStream("servera", PipeDirection.In);
            var ps = new PipeSecurity();
            ps.AddAccessRule(new PipeAccessRule("urkourbieta", PipeAccessRights.ReadWrite, System.Security.AccessControl.AccessControlType.Allow));
            ps.AddAccessRule(new PipeAccessRule("julenmartin", PipeAccessRights.ReadWrite, System.Security.AccessControl.AccessControlType.Allow));
            npssa = new NamedPipeServerStream("servera", PipeDirection.In, 1, PipeTransmissionMode.Byte, PipeOptions.None, 512, 512, ps);
            npssa.WaitForConnection();

            Console.WriteLine("Conectado");
            Console.ReadLine();
            sr = new StreamReader(npssa);
            /*
            do
            {
                //Recoger mensaje del CLIENTE DE KULENTXO
               

                mensaje = sr.ReadLine();
                

                npssa.Close();
                int WM_MENSAJE = LibreriaFunciones.Funciones.RegisterWindowMessage("Auricular");
                Process p = Process.GetProcessesByName("Pipería_ProyectoChat_")[0];
                IntPtr h = p.MainWindowHandle;

                //Enviar mensaje a Formulario principal
                npcs = new NamedPipeClientStream(".", "form2", PipeDirection.In);

                npcs.Connect();
                sw = new StreamWriter(npcs);
                sw.AutoFlush = true;
                LibreriaFunciones.Funciones.PostMessage(h, WM_MENSAJE, IntPtr.Zero, IntPtr.Zero);
                sw.WriteLine(mensaje);
                npcs.Close();

            } while (true);*/
        }
    }
}
