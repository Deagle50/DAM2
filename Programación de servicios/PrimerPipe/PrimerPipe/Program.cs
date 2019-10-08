using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Windows;

namespace PrimerPipe
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AnonymousPipeServerStream aps = new AnonymousPipeServerStream(PipeDirection.In, HandleInheritability.Inheritable))
            {
                Process p = new Process();
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "..\\..\\..\\PipeHijo\\Bin\\Debug\\PipeHijo.exe";
                psi.Arguments = aps.GetClientHandleAsString();
                psi.UseShellExecute = false;
                p.StartInfo = psi;
                p.Start();
                using(StreamReader sr = new StreamReader(aps))
                {
                    aps.DisposeLocalCopyOfClientHandle();
                    char letra;
                    letra = (char)sr.Read();
                    String mensaje="";                    
                    while (letra!='*')
                    {
                        mensaje += letra;
                        letra = (char)sr.Read();
                    }
                    MessageBox.Show(mensaje);
                }
            }
        }
    }
}
