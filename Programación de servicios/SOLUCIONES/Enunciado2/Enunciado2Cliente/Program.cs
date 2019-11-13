using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
namespace Enunciado2Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            NamedPipeClientStream npcs = new NamedPipeClientStream(".","Enunciado2", PipeDirection.InOut);
            npcs.Connect();
            StreamReader sr = new StreamReader(npcs);
            StreamWriter sw = new StreamWriter(npcs);
            sw.AutoFlush = true;
            float db, hb, importe;
    
            db = float.Parse(sr.ReadLine());       
            hb = float.Parse(sr.ReadLine());
            String pal = sr.ReadLine();
            while (pal.CompareTo("fin") != 0)
            {
                
                importe = float.Parse(sr.ReadLine());
                if (pal.CompareTo("ingreso") ==0)
                    db += importe;
                else
                    hb += importe;
                pal = sr.ReadLine();
            }
            sw.WriteLine(db);
            sw.WriteLine(hb);
            npcs.WaitForPipeDrain();
            npcs.Close();
        }
    }
}
