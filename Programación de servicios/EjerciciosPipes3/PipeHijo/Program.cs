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
            int pid;
            int cont;
            int cuantos;
            using (AnonymousPipeClientStream apcs = new AnonymousPipeClientStream(PipeDirection.In, args[0]))
            {                
                using (StreamReader sr = new StreamReader(apcs))
                {
                    pid = int.Parse(sr.ReadLine());
                    cont = int.Parse(sr.ReadLine());
                    cuantos = int.Parse(sr.ReadLine());
                    Console.WriteLine("Yo soy el hijo {0}", cont);
                    Console.WriteLine("Mi padre es {0}", pid);
                    pid = Process.GetCurrentProcess().Id;
                    Console.WriteLine("Yo soy {0}", pid);
                }
            }
            using (AnonymousPipeServerStream apss = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
            {
                Process p = new Process();
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "..\\..\\..\\PipeHijo\\Bin\\Debug\\PipeHijo.exe";
                psi.Arguments = apss.GetClientHandleAsString();
                psi.UseShellExecute = false;
                p.StartInfo = psi;
                p.Start();        
                
                }
            }
        }
    }
