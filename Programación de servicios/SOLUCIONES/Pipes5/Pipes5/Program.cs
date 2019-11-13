using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Pipes5
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProcessStartInfo psi = new ProcessStartInfo();
            //psi.FileName = "..\\..\\..\\Hijo1\\bin\\debug\\hijo1.exe";
            //Process p = new Process();
            //p.StartInfo = psi;
            //p.Start();
            //psi.FileName= "..\\..\\..\\Hijo2\\bin\\debug\\hijo2.exe";
            //p.StartInfo = psi;
            //p.Start();
            Process.Start("..\\..\\..\\Hijo1\\bin\\debug\\hijo1.exe");
            Process.Start("..\\..\\..\\Hijo2\\bin\\debug\\hijo2.exe");

        }
    }
}
