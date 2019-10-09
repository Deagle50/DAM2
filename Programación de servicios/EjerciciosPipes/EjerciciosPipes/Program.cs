using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.IO.Pipes;
using System.Windows;

namespace EjerciciosPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            using (AnonymousPipeServerStream aps = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
            {
                Process p = new Process();
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "..\\..\\..\\PipeHijo\\Bin\\Debug\\PipeHijo.exe";
                psi.Arguments = aps.GetClientHandleAsString();
                psi.UseShellExecute = false;
                p.StartInfo = psi;
                p.Start();
                using (StreamWriter sw = new StreamWriter(aps)) {
                    num = int.Parse(Console.ReadLine());
                    num += 2;
                    Console.WriteLine(num);
                    sw.WriteLine(num);
                }
                
                    
                
            }
        }
    }
}
