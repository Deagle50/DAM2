using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;

namespace PipeHijo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            NamedPipeServerStream npss = new NamedPipeServerStream("Hijo1", PipeDirection.InOut);
            StreamWriter sw = new StreamWriter(npss);
            StreamReader sr = new StreamReader(npss);

            npss.WaitForConnection();
            sw.AutoFlush = true;



            npss.Close();
            sw.Close();
            sr.Close();
        }
    }
}
