using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Pipes;
using System.IO;

namespace Servidor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (NamedPipeServerStream npcs = new NamedPipeServerStream("pipecli", PipeDirection.InOut))
            {
                npcs.WaitForConnection();
                StreamWriter sw = new StreamWriter(npcs);
                sw.AutoFlush = true;
                StreamReader sr = new StreamReader(npcs);
                int num= new Random(DateTime.Now.Millisecond).Next(1, 100);
                int adv = int.Parse(sr.ReadLine());
                while(num!=adv)
                {
                    Console.WriteLine(adv);
                    if(adv>num)
                    {
                        sw.WriteLine("MAYOR");

                    }
                    else
                    {
                        sw.WriteLine("MENOR");
                    }
                    adv = int.Parse(sr.ReadLine());
                }
                sw.WriteLine("correcto");
            }
        }
    }
}
