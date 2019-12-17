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
            NamedPipeClientStream npcsCliente;
            StreamWriter swC;
            StreamReader srC, srA;  //Cliente, archivo(file)

            string palabra;
            string nombre;
           
            npcsCliente = new NamedPipeClientStream(".", "serverCliente", PipeDirection.InOut);
           
            npcsCliente.Connect();
            swC = new StreamWriter(npcsCliente);
            swC.AutoFlush = true;
            srC = new StreamReader(npcsCliente);

            palabra=srC.ReadLine();
            Console.WriteLine(palabra);
            Console.WriteLine("Introduce el nombre del fichero: ");
            nombre = Console.ReadLine();

            swC.WriteLine(nombre);

            srA = new StreamReader(nombre);
            palabra = srC.ReadLine();
            Console.WriteLine(palabra);
            palabra = srA.ReadLine();
            while (palabra != null)
            {
                swC.WriteLine(palabra);
                palabra = srC.ReadLine();
                Console.WriteLine();
                palabra = srA.ReadLine();
            }
            swC.WriteLine("EOF");
            Console.ReadLine();
            
        }
    }
}
