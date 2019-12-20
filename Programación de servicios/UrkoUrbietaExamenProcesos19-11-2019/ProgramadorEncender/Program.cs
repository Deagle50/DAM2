using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ProgramadorEncender
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
            StreamWriter swF;

            IntPtr hwnd;

            int tiempo;
            int idMsgProgramarEncender;

            idMsgProgramarEncender = RegisterWindowMessage("WM_PROGRAMAR_ENCENDER");

            npcsForm = new NamedPipeClientStream(".", "serverPro", PipeDirection.Out);

            //Conectar pipe
            npcsForm.Connect();
            swF = new StreamWriter(npcsForm);
            swF.AutoFlush = true;

            //Pedir minutos a enviar
            tiempo = pedirNum();

            //Enviar mensaje wm_programar_encender
            hwnd = Process.GetProcessesByName("UrkoUrbietaExamenProcesos19-11-2019")[0].MainWindowHandle;
            PostMessage(hwnd, idMsgProgramarEncender, IntPtr.Zero, IntPtr.Zero);
            Console.WriteLine("Mensaje enviado");

            //Mandar minutos
            swF.WriteLine(tiempo);

            swF.Close();            
            npcsForm.Close();
            //Fin de programa            
        }

        static int pedirNum()
        {
            int tiempo;
            bool esInt=false;
            Console.WriteLine("Escribe la cantidad de minutos a esperar para encender la bombilla");
            if (int.TryParse(Console.ReadLine(), out tiempo))
            {
                esInt = true;
            }
            while (!esInt)
            {//Repetir pedir minutos mientras no meta int
                Console.WriteLine("Escribe la cantidad de minutos a esperar para encender la bombilla");
                if (int.TryParse(Console.ReadLine(), out tiempo))
                {
                    esInt = true;
                }
                
            }
            return tiempo;
        }
    }
}
