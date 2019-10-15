using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Windows;
using System.Diagnostics;

namespace EjerciciosPipes2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                using (AnonymousPipeServerStream apss = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
                {
                    using (StreamWriter sw = new StreamWriter(apss))
                    {
                        
                        sw.AutoFlush = true;
                        ProcessStartInfo psi = new ProcessStartInfo();
                        psi.FileName = "..\\..\\..\\PipeHijo1\\Bin\\Debug\\PipeHijo1.exe";
                        psi.Arguments = apss.GetClientHandleAsString();
                        psi.UseShellExecute = false;
                        Process p1 = new Process();
                        p1.StartInfo = psi;
                        p1.Start();
                        sw.WriteLine(i+1);
                        sw.WriteLine(Process.GetCurrentProcess().Id);
                    }
                }
            }
        }
    }
}



