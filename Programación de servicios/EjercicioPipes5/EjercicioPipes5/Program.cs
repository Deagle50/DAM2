using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;

namespace EjercicioPipes5
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            Process p = new Process();

            //Iniciar primer hijo
            psi.FileName = "..\\..\\..\\PipeHijo1\\Bin\\Debug\\PipeHijo1.exe";
            p.StartInfo = psi;
            p.Start();
            //Iniciar segundo hijo
            psi.FileName = "..\\..\\..\\PipeHijo2\\Bin\\Debug\\PipeHijo2.exe";
            p.StartInfo = psi;
            p.Start();
        }
    }
}
