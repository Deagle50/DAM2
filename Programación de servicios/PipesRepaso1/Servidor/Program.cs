using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Servidor
{
    class Program
    {
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string mensaje);
        [DllImport("user32")]
        public static extern int PostMessage(IntPtr dest, int IdMensaje, IntPtr wparam, IntPtr lparam);
        static void Main(string[] args)
        {
            NamedPipeServerStream npssForm;            
            NamedPipeServerStream npssCliente;
            StreamWriter swC, swF;
            StreamReader srC;
            string nombre, linea;
            int idMensajeInfo;
            IntPtr hwnd;

            idMensajeInfo = RegisterWindowMessage("WM_INFO");

            npssForm = new NamedPipeServerStream("serverForm", PipeDirection.Out);
            npssCliente = new NamedPipeServerStream("serverCliente", PipeDirection.InOut);
            

            npssForm.WaitForConnection();
            npssCliente.WaitForConnection();
            //Pedir nombre
            swC = new StreamWriter(npssCliente);
            swC.WriteLine("File?");

            srC = new StreamReader(npssCliente);
            nombre = srC.ReadLine().ToString();

            //Crear fichero con x nombre
            swF = File.CreateText(nombre);

            //Pedir línea
            swC.WriteLine("Next");
            linea = srC.ReadLine();
            swF.WriteLine(linea);
            while (linea != "EOF")
            {
                swC.WriteLine("Next");
                linea = srC.ReadLine();
                swF.WriteLine(linea);
            }

            hwnd = Process.GetProcessesByName("PipesRepaso1")[0].MainWindowHandle;
            PostMessage(hwnd, idMensajeInfo, IntPtr.Zero, IntPtr.Zero);
        }
    }
}
