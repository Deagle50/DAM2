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
            StreamWriter swC, swF, swA; //Cliente, Formulario, Archivo(file)
            StreamReader srC;

            string nombre, linea;
            int idMensajeInfo;
            IntPtr hwnd;
            int caracteres=0, cont =0;
            float longMedia;

            idMensajeInfo = RegisterWindowMessage("WM_INFO");

            npssForm = new NamedPipeServerStream("serverForm", PipeDirection.Out);
            npssCliente = new NamedPipeServerStream("serverCliente", PipeDirection.InOut);
            
            //Conectar con formulario
            npssForm.WaitForConnection();
            swF = new StreamWriter(npssForm);
            swF.AutoFlush=true;

            //Conectar con cliente
            npssCliente.WaitForConnection();
            swC = new StreamWriter(npssCliente);
            swC.AutoFlush = true;
            srC = new StreamReader(npssCliente);

            swC.WriteLine("File?");
            nombre = srC.ReadLine().ToString();

            //Crear fichero con x nombre
            swA = new StreamWriter(nombre+".txt");

            //Pedir línea
            swC.WriteLine("Next");
            linea = srC.ReadLine();
            
            //Pedir línea mientras no se reciba EOF
            while (linea.CompareTo("EOF") != 0)
            {
                cont++;
                caracteres += linea.Length;
                swA.WriteLine(linea);
                swC.WriteLine("Next");
                linea = srC.ReadLine();
                
            }
            
            longMedia = caracteres / cont;
            swA.Close();
            npssCliente.Close();

            hwnd = Process.GetProcessesByName("PipesRepaso1")[0].MainWindowHandle;
            PostMessage(hwnd, idMensajeInfo, IntPtr.Zero, IntPtr.Zero);

            swF.WriteLine(nombre);
            swF.WriteLine(caracteres.ToString());
            swF.WriteLine(longMedia.ToString());
            Console.ReadLine();
        }
    }
}
