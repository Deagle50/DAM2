using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppEF1.Models;

namespace ConsoleAppEF1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new DAM_urkourbieta_DEVEntities())
            {

                List<Personas> mayores = contexto.Personas.Where(p1 => p1.Edad > 15).ToList();
                foreach (Personas p in mayores)
                {
                    Console.WriteLine(p.Nombre + " " + p.Apellido);
                }

                Personas pers = new Personas();
                int i;

                //update

                Console.WriteLine("Escribe num");
                i = int.Parse(Console.ReadLine());
                
                pers = contexto.Personas.Find(i);

                contexto.Personas.Where(p => p.IDPersona == i).FirstOrDefault();

                Console.WriteLine("Escribe nombre");
                pers.Nombre = Console.ReadLine();
                
                contexto.SaveChanges();
                                
            }            
        }
    }
}
