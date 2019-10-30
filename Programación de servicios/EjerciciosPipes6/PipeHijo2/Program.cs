using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;

namespace PipeHijo2
{
    class Program
    {
        static void Main(string[] args)
        {
            NamedPipeClientStream npcs = new NamedPipeClientStream(".", "Padre", PipeDirection.InOut);
            StreamWriter sw = new StreamWriter(npcs);
            StreamReader sr = new StreamReader(npcs);

            npcs.Connect();
            sw.AutoFlush = true;
        }
    }
}
