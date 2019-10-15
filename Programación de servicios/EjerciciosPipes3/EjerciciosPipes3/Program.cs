using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;

namespace EjerciciosPipes3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 3;
            int i = 0;
            using (AnonymousPipeServerStream apss = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
                {
                    Process p = new Process();
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = "..\\..\\..\\PipeHijo\\Bin\\Debug\\PipeHijo.exe";
                    psi.Arguments = apss.GetClientHandleAsString();
                    psi.UseShellExecute = false;
                    p.StartInfo = psi;
                    p.Start();
                    using (StreamWriter sw = new StreamWriter(apss))
                    {
                        Console.WriteLine("Soy el padre");
                        sw.WriteLine(n);
                        sw.WriteLine(i);
                        
                    }
                }
        }
    }
}
