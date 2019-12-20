using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Diagnostics;

namespace TemporizadorEncender
{
    class Program
    {
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string message);
        [DllImport("user32")]
        public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);
        [DllImport("user32")]
        public static extern int FindWindow(String clase, String title);
        static void Main(string[] args)
        {               
            NamedPipeClientStream npcsForm;
            StreamReader srF;            
            DateTime horaFin = new DateTime();
            IntPtr hwnd;
            int idMsgEncender;
            string stringFin;

            idMsgEncender = RegisterWindowMessage("WM_ENCENDER");

            npcsForm = new NamedPipeClientStream(".", "serverTem", PipeDirection.In);
            
            //Conectar con formulario principal
            npcsForm.Connect();
            srF = new StreamReader(npcsForm);
            Console.WriteLine("conectado");

            //Recibir hora fin y mostrarla
            stringFin = srF.ReadLine();
            horaFin=Convert.ToDateTime(stringFin);
            Console.WriteLine(horaFin.ToString());
            //Mostrar cuenta atrás
            while (horaFin > DateTime.Now)
            {
                Console.WriteLine((horaFin - DateTime.Now).ToString());
                Thread.Sleep(1000);
            }

            hwnd= Process.GetProcessesByName("UrkoUrbietaExamenProcesos19-11-2019")[0].MainWindowHandle;
            PostMessage(hwnd, idMsgEncender, IntPtr.Zero, IntPtr.Zero);
            //Fin de ejecución
            srF.Close();            
            npcsForm.Close();
        }
    }
}
