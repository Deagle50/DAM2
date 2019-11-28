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
            
            NamedPipeServerStream npssm;
            NamedPipeClientStream npcs;
            StreamReader sr;
            StreamWriter sw;
            string mensaje;

            //Recoger mensaje del servidor
            /*npcs= new NamedPipeClientStream(".", "form", PipeDirection.In);
            sr = new StreamReader(npcs);

            npcs.Connect();

            mensaje = sr.ReadLine();

            Console.WriteLine("Conectado");            
            Console.WriteLine(mensaje);
            Console.ReadLine();

            npcs.Close();*/
                
            //Enviar mensaje al auricular del cliente
            npssm = new NamedPipeServerStream("server", PipeDirection.Out);
            

            npssm.WaitForConnection();
            Console.WriteLine("Microfono conectado");
            Console.ReadLine();
            /*sw = new StreamWriter(npssm);

            sw.AutoFlush = true;
            sw.WriteLine(mensaje);
            npssm.Close();*/
            
        }
    }
}
