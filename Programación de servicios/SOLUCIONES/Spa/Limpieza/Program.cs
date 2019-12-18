using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Limpieza
{
    class Program
    {
        static void Main(string[] args)
        {   Boolean res;
            Mutex mutexLimpieza;
            do
            { mutexLimpieza = new Mutex(false, "MutexUsuario", out res);
              mutexLimpieza.Dispose();
            }
            while (!res);
            mutexLimpieza = new Mutex(false, "MutexLimpieza", out res);
            mutexLimpieza.WaitOne();
            DateTime actual = DateTime.Now;
            while((DateTime.Now-actual).TotalSeconds<5)
            {
                Console.Write("Ras Ras Ras");
            }
            mutexLimpieza.ReleaseMutex();
            mutexLimpieza.Dispose();
        }
    }
}
