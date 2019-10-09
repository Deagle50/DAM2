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
            for (int i = 1; i <= 3; i++)
            {
                using (AnonymousPipeServerStream apss = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
                {

                    Process p1 = new Process();
                    ProcessStartInfo psi1 = new ProcessStartInfo();
                    psi1.FileName = "..\\..\\..\\PipeHijo\\Bin\\Debug\\PipeHijo.exe";
                    psi1.Arguments = apss.GetClientHandleAsString();
                    psi1.UseShellExecute = false;
                    p1.StartInfo = psi1;
                    p1.Start();

                    //Process p2 = new Process();
                    //ProcessStartInfo psi2 = new ProcessStartInfo();
                    //psi2.FileName = "..\\..\\..\\PipeHijo\\Bin\\Debug\\PipeHijo.exe";
                    //psi2.Arguments = apss.GetClientHandleAsString();
                    //psi2.UseShellExecute = false;
                    //p2.StartInfo = psi2;
                    //p2.Start();

                    //Process p3 = new Process();
                    //ProcessStartInfo psi3 = new ProcessStartInfo();
                    //psi3.FileName = "..\\..\\..\\PipeHijo\\Bin\\Debug\\PipeHijo.exe";
                    //psi3.Arguments = apss.GetClientHandleAsString();
                    //psi3.UseShellExecute = false;
                    //p3.StartInfo = psi3;
                    //p3.Start();

                    using (StreamWriter sw = new StreamWriter(apss))
                    {
                        sw.Write(i);

                    }

                    using (StreamReader sr = new StreamReader(apss))
                    {

                    }
                }
            }
        }
    }
}



