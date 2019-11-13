using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;
namespace Pipes3
{
    class Program
    {

        static void Main(string[] args)
        {

            int cuantos;
            Console.WriteLine("Introduce Número: ");
            cuantos = int.Parse(Console.ReadLine());
            using (AnonymousPipeServerStream apss = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
            {
                using (StreamWriter sw = new StreamWriter(apss))
                {
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = "..\\..\\..\\Pipes3Hijo\\bin\\Debug\\Pipes3Hijo.exe";
                    psi.UseShellExecute = false;
                    psi.Arguments = apss.GetClientHandleAsString();
                    Process.Start(psi);
                    sw.AutoFlush = true;
                    sw.WriteLine(Process.GetCurrentProcess().Id);
                    sw.WriteLine(1);
                    sw.WriteLine(cuantos);
                }
            }
            Console.ReadLine();
        }
    }        
}
 
