using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Pipes;
using System.IO;
namespace Hijo2
{
    class Program
    {
        static void Main(string[] args)
        {
            NamedPipeClientStream npcs = new NamedPipeClientStream("192.168.37.170", "pipes5", PipeDirection.In);
            npcs.Connect();
            StreamReader sr = new StreamReader(npcs);
            Console.WriteLine("Conexión Aceptada");
            String pal = sr.ReadLine();
            while(pal.ToLower().CompareTo("fin")!=0)
            {
                Console.WriteLine(pal);
                pal = sr.ReadLine();
            }
            npcs.Close();
                }
        
    }
}
