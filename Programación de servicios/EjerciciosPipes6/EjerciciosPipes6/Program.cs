using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;

namespace EjerciciosPipes6
{
    class Program
    {
        static void Main(string[] args)
        {
            Process p1 = new Process();
            ProcessStartInfo psi1 = new ProcessStartInfo();
            Process p2 = new Process();
            ProcessStartInfo psi2 = new ProcessStartInfo();

            psi1.FileName = "..\\..\\..\\PipeHijo1\\Bin\\Debug\\PipeHijo1.exe";            
            psi1.UseShellExecute = false;
            p1.StartInfo = psi1;
            p1.Start();

            psi2.FileName = "..\\..\\..\\PipeHijo1\\Bin\\Debug\\PipeHijo1.exe";            
            psi2.UseShellExecute = false;
            p2.StartInfo = psi2;
            p2.Start();

            //Fin de programa
        }
    }
}
