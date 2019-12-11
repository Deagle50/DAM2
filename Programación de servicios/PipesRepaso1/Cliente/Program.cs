using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            NamedPipeClientStream npcs1, npcs2;
           
            npcs1 = new NamedPipeClientStream(".", "serverCliente", PipeDirection.InOut);
            //npcs2 = new NamedPipeClientStream(".", "server", PipeDirection.)
            npcs1.Connect();

        }
    }
}
