using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
namespace Pipes3Hijo
{
    class Program
    {
        static void Main(string[] args)
        {
            int pid, cont, cuantos,pidYo;
            using (AnonymousPipeClientStream spcs=new AnonymousPipeClientStream(PipeDirection.In,args[0]))
            {
                using (StreamReader sr=new StreamReader(spcs))
                {
                    pid=int.Parse(sr.ReadLine());
                    cont = int.Parse(sr.ReadLine());
                    cuantos = int.Parse(sr.ReadLine());
                }
                
            }
            Console.WriteLine("Soy el hijo {0}", cont);
            Console.WriteLine("Mi padres es {0}", pid);
            pidYo = Process.GetCurrentProcess().Id;
            Console.WriteLine("Yo soy {0}", pidYo);
            if (cont < cuantos)
            {
                using (AnonymousPipeServerStream apss = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
                {
                    using (StreamWriter sw = new StreamWriter(apss))
                    {
                        ProcessStartInfo psi = new ProcessStartInfo();
                        psi.FileName = "Pipes3Hijo.exe";
                        psi.UseShellExecute = false;
                        psi.Arguments = apss.GetClientHandleAsString();
                        Process.Start(psi);
                        sw.AutoFlush = true;
                        sw.WriteLine(Process.GetCurrentProcess().Id);
                        sw.WriteLine(cont + 1);
                        sw.WriteLine(cuantos);
                    }
                }
            }
        }
    }
}
