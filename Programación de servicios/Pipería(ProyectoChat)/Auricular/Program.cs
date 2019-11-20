using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Pipes;
using System.IO;

namespace Auricular
{
    class Program
    {
        static void Main(string[] args)
        {
            NamedPipeClientStream npcs;
            NamedPipeServerStream npssa;
            StreamReader sr;
            StreamWriter sw;
            string mensaje;
            //Recoger mensaje del servidor
            npcs = new NamedPipeClientStream(".", "form2", PipeDirection.In);
            sr = new StreamReader(npcs);
            
            npcs.Connect();

                mensaje = sr.ReadLine();
                Console.WriteLine(mensaje);
                Console.ReadLine();

                //Enviar mensaje al auricular del cliente
                npssa = new NamedPipeServerStream("servera", PipeDirection.Out);
                npssa.WaitForConnection();
                sw = new StreamWriter(npssa);
                sw.WriteLine(mensaje);
            
        }
    }
}
