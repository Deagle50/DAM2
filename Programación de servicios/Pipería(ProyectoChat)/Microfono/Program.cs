using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO.Pipes;
using System.IO;

namespace Microfono
{
    class Program
    {
        static void Main(string[] args)
        {
            NamedPipeClientStream npcs;
            NamedPipeServerStream npssm;
            StreamReader sr;
            StreamWriter sw;
            //Recoger mensaje del servidor
            npcs = new NamedPipeClientStream(".", "server", PipeDirection.InOut);
            sr = new StreamReader(npcs);
            string mensaje;
            npcs.Connect();
            do
            {
                mensaje = sr.ReadLine();
                Console.WriteLine(mensaje);
                Console.ReadLine();

                //Enviar mensaje al auricular del cliente
                npssm = new NamedPipeServerStream("serverm", PipeDirection.Out);
                npssm.WaitForConnection();
                sw = new StreamWriter(npssm);
                sw.WriteLine(mensaje);
            } while (true);
        }
    }
}
