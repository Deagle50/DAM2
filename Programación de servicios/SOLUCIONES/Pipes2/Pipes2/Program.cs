using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;
namespace Pipes2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=3;i++)
            {
                using (AnonymousPipeServerStream spss=new AnonymousPipeServerStream(PipeDirection.Out,HandleInheritability.Inheritable))
                {
                    using (StreamWriter sw=new StreamWriter(spss))
                    {
                        sw.AutoFlush=true;
                        ProcessStartInfo pi = new ProcessStartInfo();
                        pi.FileName = "..\\..\\..\\Pipes2Hijo\\Bin\\Debug\\Pipes2Hijo.exe";
                        pi.Arguments = spss.GetClientHandleAsString();
                        pi.UseShellExecute = false;
                        Process p = new Process();
                        p.StartInfo = pi;
                        p.Start();
                        sw.WriteLine(i);
                        sw.WriteLine(Process.GetCurrentProcess().Id);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
