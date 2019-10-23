using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;

namespace PipeHijo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i;
            using (AnonymousPipeClientStream apcs = new AnonymousPipeClientStream(PipeDirection.In, args[0]))
            {
                Process p = new Process.GetCurrentProcess();
                using (StreamReader sr = new StreamReader(apcs))
                {
                    n = Int32.Parse(sr.ReadLine());
                    i = Int32.Parse(sr.ReadLine());
                }
            }
            if(i<n)
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
                        
                    Console.WriteLine("Yo soy el hijo {0}, mi padre es PID={1}, yo soy PID={2}", i, );
                    sw.WriteLine(n);
                    sw.WriteLine(i);
                        if(i<3)
                            i++;
                }
            }
        }
    }
}
