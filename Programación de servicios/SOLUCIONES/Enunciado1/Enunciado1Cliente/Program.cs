using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
namespace Enunciado1Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            NamedPipeClientStream npcs = new NamedPipeClientStream(".", "Enunciado1", PipeDirection.InOut);
            npcs.Connect();
            StreamReader sr = new StreamReader(npcs);
            StreamWriter sw = new StreamWriter(npcs);
            sw.AutoFlush = true;
            int x, y;
            x = int.Parse(sr.ReadLine());
            y = int.Parse(sr.ReadLine());
            Console.SetCursorPosition(x, y);
            Console.Write("*");
            String pal = sr.ReadLine();
            while (pal.CompareTo("fin") != 0)
            {
                if (pal.CompareTo("up") == 0)
                {
                    y--;
                }
                else if (pal.CompareTo("down") == 0)
                {
                    y++;
                }
                else if (pal.CompareTo("left") == 0)
                {
                    x--;
                }
                else
                {
                    x++;
                }
                Console.SetCursorPosition(x, y);
                Console.Write("*");
                pal = sr.ReadLine();
            }
                sw.WriteLine(x);
                sw.WriteLine(y);
                npcs.WaitForPipeDrain();
                npcs.Close();
            
        }
    }
}
