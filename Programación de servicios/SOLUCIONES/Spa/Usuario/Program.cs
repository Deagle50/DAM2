using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Mensajes;
using System.Diagnostics;
namespace Usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            int MSG_ENTRA,  MSG_COGE_TOALLA, MSG_DEJA_TOALLA, MSG_DUCHA_IN,MSG_DUCHA_OUT;
            Semaphore semaforousuario=Semaphore.OpenExisting("semaforoUsuario");
            Mutex mutexUsuario = Mutex.OpenExisting("mutexUsuario");
            /*Registrar mensajes*/
            MSG_ENTRA = Funciones.RegisterWindowMessage("MSG_ENTRA");
            MSG_COGE_TOALLA = Funciones.RegisterWindowMessage("MSG_COGE_TOALLA");
            MSG_DEJA_TOALLA = Funciones.RegisterWindowMessage("MSG_DEJA_TOALLA");
            MSG_DUCHA_IN = Funciones.RegisterWindowMessage("MSG_DUCHA_IN");
            MSG_DUCHA_OUT = Funciones.RegisterWindowMessage("MSG_DUCHA_OUT");
            /*Toalla*/
           IntPtr hwnd=Process.GetProcessesByName("spa")[0].MainWindowHandle;
            /*Comprueba que no están limpiando*/
            Boolean res;
            Mutex mutexLimpieza;
            do
            { mutexLimpieza = new Mutex(false, "MutexLimpieza", out res);
              mutexLimpieza.Dispose();
            }
            while (!res);
            mutexLimpieza = new Mutex(false, "MutexUsuario", out res);
            
            /*Entra usuario*/
            Funciones.PostMessage(hwnd, MSG_ENTRA, IntPtr.Zero, IntPtr.Zero);
            
            semaforousuario.WaitOne();
            
            /*COGE TOALLA*/
            Funciones.PostMessage(hwnd, MSG_COGE_TOALLA, IntPtr.Zero, IntPtr.Zero);

            mutexUsuario.WaitOne();
            /*ENTRA EN LA DUCHA*/
            Funciones.PostMessage(hwnd, MSG_DUCHA_IN, IntPtr.Zero, IntPtr.Zero);

            /*proceso ducha*/
            DateTime actual = DateTime.Now;
            long quiere = new Random(DateTime.Now.Millisecond).Next(5, 45);
            while((DateTime.Now-actual).TotalSeconds<45&& (DateTime.Now - actual).TotalSeconds <quiere)
            {
                Console.Out.Write("lorolo");
               
            }

            /*SALE DE LA DUCHA*/
            mutexUsuario.ReleaseMutex();
            Funciones.PostMessage(hwnd, MSG_DUCHA_OUT, IntPtr.Zero, IntPtr.Zero);
            /*DEJA TOALLA*/
            Funciones.PostMessage(hwnd, MSG_DEJA_TOALLA, IntPtr.Zero, IntPtr.Zero);
            semaforousuario.Release();
            mutexLimpieza.Dispose();
        }
    }
}
