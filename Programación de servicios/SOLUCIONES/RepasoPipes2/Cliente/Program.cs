using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mensajes;
using System.IO.Pipes;
using System.IO;
using System.Diagnostics;
namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            String STR_WM_MAYOR = "WM_MAYOR", STR_WM_MENOR = "WM_MENOR", STR_WM_IGUAL = "WM_IGUAL";
            int WM_MAYOR, WM_MENOR, WM_IGUAL;
            WM_IGUAL = Funciones.RegisterWindowMessage(STR_WM_IGUAL);
            WM_MAYOR = Funciones.RegisterWindowMessage(STR_WM_MAYOR);
            WM_MENOR = Funciones.RegisterWindowMessage(STR_WM_MENOR);

            using (NamedPipeClientStream npcs = new NamedPipeClientStream(".", "pipecli", PipeDirection.InOut))
            {
                IntPtr hndl;
                hndl = Process.GetProcessesByName("RepasoPipes2")[0].MainWindowHandle;
                npcs.Connect();
                StreamReader sr = new StreamReader(npcs);
                StreamWriter sw = new StreamWriter(npcs);
                sw.AutoFlush = true;
                Console.WriteLine("Número");
                int num = int.Parse(Console.ReadLine());
                sw.WriteLine(num);
                String resp = sr.ReadLine();
                while (resp.CompareTo("correcto") != 0)
                {
                    if (resp.CompareTo("MAYOR") == 0)
                    {

                        Funciones.PostMessage(hndl, WM_MAYOR, IntPtr.Zero, IntPtr.Zero);
                    }
                    else if (resp.CompareTo("MENOR") == 0)
                    {
                        Funciones.PostMessage(hndl, WM_MENOR, IntPtr.Zero, IntPtr.Zero);
                    }
                    Console.WriteLine("Número");
                    num = int.Parse(Console.ReadLine());
                    sw.WriteLine(num);
                    resp = sr.ReadLine();
                }
                Funciones.PostMessage(hndl, WM_IGUAL, IntPtr.Zero, IntPtr.Zero);
            }
        }
    }
}
