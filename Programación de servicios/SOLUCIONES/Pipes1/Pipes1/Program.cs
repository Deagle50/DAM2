using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO.Pipes;
using System.IO;
namespace Pipes1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AnonymousPipeServerStream aps=new AnonymousPipeServerStream(PipeDirection.Out,HandleInheritability.Inheritable))
            {
                using (StreamWriter sw=new StreamWriter(aps))
                {
                    sw.AutoFlush = true;
                    ProcessStartInfo pi = new ProcessStartInfo();
                    pi.FileName = "..\\..\\..\\Pipes1Hijo\\bin\\Debug\\Pipes1Hijo.exe";
                    pi.UseShellExecute = false;
                    pi.Arguments = aps.GetClientHandleAsString();
                    Process p = new Process();
                    p.StartInfo = pi;
                    p.Start();
                    Console.WriteLine("Número: ");
                    int num;
                    num = int.Parse(Console.ReadLine());
                    num += 2;
                    Console.WriteLine("PID {0} Número {1}", Process.GetCurrentProcess().Id, num);
                    sw.WriteLine(num);
                    
                }
            }
        }
    }
}
