using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Usuario
{
    class Program
    {
        
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string mensaje);
        [DllImport("user32")]
        public static extern int PostMessage(IntPtr dest, int IdMensaje, IntPtr wparam, IntPtr lparam);

        static void Main(string[] args)
        {
            ConsoleColor[] colores = { ConsoleColor.Yellow, ConsoleColor.Red, ConsoleColor.Green,
                                        ConsoleColor.Yellow, ConsoleColor.White, ConsoleColor.Magenta,
                                        ConsoleColor.DarkYellow, ConsoleColor.Cyan, ConsoleColor.DarkBlue,
                                        ConsoleColor.DarkCyan, ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta,
                                        ConsoleColor.DarkRed, ConsoleColor.DarkGray, ConsoleColor.Black, ConsoleColor.Blue};

            int idmensajeEntra, idmensajeCogeToalla, idmensajeDejaToalla, idmensajeDuchaIn, idmensajeDuchaOut;
            bool repetir = true;
            DateTime actual;
            int quiere;

            Random r = new Random();
            Semaphore sem, semducha;
            Mutex mutexUsuario;

            sem = Semaphore.OpenExisting("semaforo_toalla");
            semducha = Semaphore.OpenExisting("semaforo_ducha");
            mutexUsuario = Mutex.OpenExisting("mutexUsuario");

            idmensajeEntra = RegisterWindowMessage("WM_ENTRA");
            idmensajeCogeToalla = RegisterWindowMessage("WM_COGE");
            idmensajeDejaToalla = RegisterWindowMessage("WM_DEJA_TOALLA");
            idmensajeDuchaIn = RegisterWindowMessage("WM_DUCHA_IN");
            idmensajeDuchaOut = RegisterWindowMessage("WM_DUCHA_OUT");

            IntPtr hwnd = Process.GetProcessesByName("SpaDeLujo")[0].MainWindowHandle;

            PostMessage(hwnd, idmensajeEntra, IntPtr.Zero, IntPtr.Zero);
            sem.WaitOne();

            PostMessage(hwnd, idmensajeCogeToalla, IntPtr.Zero, IntPtr.Zero);
            
            //Validar que solo uno pueda entrar a la ducha
            mutexUsuario.WaitOne();
            //semducha.WaitOne();
            PostMessage(hwnd, idmensajeDuchaIn, IntPtr.Zero, IntPtr.Zero);

            actual = DateTime.Now;
            quiere = r.Next(5000, 45000);
            while ((DateTime.Now - actual).TotalSeconds < 77/* && (DateTime.Now.Millisecond-actual)<quiere*/)
            {
                int i = r.Next(0, colores.Length);
                Console.BackgroundColor = colores[i];
                Console.Write("Lolorolo");
            }
            Console.Clear();
            Console.WriteLine("Fin de ducha");

            //do
            //{
            //    Console.Write("lorolorololo");
            //    if (r.Next(1, 1000002) > 999998)
            //    {
            //        repetir = false;
            //    }
            //} while (repetir);


            //Sale ducha

            PostMessage(hwnd, idmensajeDuchaOut, IntPtr.Zero, IntPtr.Zero);
            mutexUsuario.ReleaseMutex();
            //semducha.Release();

            //Deja toalla            
            PostMessage(hwnd, idmensajeDejaToalla, IntPtr.Zero, IntPtr.Zero);
            sem.Release();

            Console.ReadLine();
        }
    }
}
