using System;
using ODOOConsole.Models;
using System.Linq;
using System.Collections.Generic;


namespace ODOOConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obtener aplicaciones ODOO
            OdooDBContext odooDB = new OdooDBContext();
            string licencia = "LGPL-3";

            List<IrModuleModule> modules = odooDB.IrModuleModule.ToList();
            
            Console.WriteLine("Instaladas");

            foreach(IrModuleModule m in modules)
            {
                if(m.State=="installed")
                {
                    mostrarDatos(m);                    
                }
            }
            Console.WriteLine("APLICACIONES NO INSTALADAS QUE TIENEN LA LICENCIA LGPL-3");

            foreach(IrModuleModule m in modules)
            {
                if(m.State=="installed")
                {
                    if(m.License==licencia){
                    mostrarDatos(m);
                    }
                }
                
            }
            //Fin obtener aplicaciones ODOO
            Console.ReadLine();
        }

        public static void mostrarDatos(IrModuleModule m){
            Console.WriteLine("////////////////////////");
            Console.WriteLine(m.Name);
            Console.WriteLine(m.Shortdesc);
            Console.WriteLine(m.Author);
            Console.WriteLine(m.Demo);
            Console.WriteLine(m.Web);
            Console.WriteLine("////////////////////////");
        }
    }
}
