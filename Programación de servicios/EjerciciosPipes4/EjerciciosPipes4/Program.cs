using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Windows;

namespace EjerciciosPipes4
{
    class Program
    {
        static void Main(string[] args)
        {

            int cuantos;
            Console.WriteLine("Escribe un número");
            cuantos = int.Parse(Console.ReadLine());
            int i = 1;
            using (AnonymousPipeServerStream apss = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
            {
                using (StreamWriter sw = new StreamWriter(apss))
                {
                    Process p = new Process();
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = "..\\..\\..\\PipeHijo\\Bin\\Debug\\PipeHijo.exe";
                    psi.Arguments = apss.GetClientHandleAsString();
                    psi.UseShellExecute = false;
                    p.StartInfo = psi;
                    p.Start();
                    Console.WriteLine("Soy el padre");                    
                    sw.WriteLine(cuantos);
                }            
            }
        }
    }
}