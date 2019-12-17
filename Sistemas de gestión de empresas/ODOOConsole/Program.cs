using System;
using ODOOConsole.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace ODOOConsole
{
    class Program
    {
        private string contrasena = "Host=localhost;Database=OdooDB;Username=openpg;Password=openpgpwd";
        static void Main(string[] args)
        {
            //Obtener aplicaciones ODOO
            OdooDBContext odooDB = new OdooDBContext();
            const string licencia = "LGPL-3";
            const string instalada = "installed";
            

            //Lista de modulos instalados
            List<IrModuleModule> modulosInstalados = 
                odooDB.IrModuleModule.Where(m=>m.State==instalada).ToList();
            //Lista de modulos instalados con licencia concreta
            List<IrModuleModule> modulosConLicenciaInstalados =
                odooDB.IrModuleModule.Where(m=>m.State==instalada&& m.License == licencia).ToList();
            //
            List<ResPartner> partners =
                odooDB.ResPartner.FromSqlRaw("SELECT * FROM public.getPartners()").ToList();


            /*
            Console.WriteLine("APLICACIONES INSTALADAS");
            foreach(IrModuleModule m in modulosInstalados)
            {
                mostrarDatos(m);                
            }

            Console.WriteLine("APLICACIONES NO INSTALADAS QUE TIENEN LA LICENCIA LGPL-3");
            foreach(IrModuleModule m in modulosConLicenciaInstalados)
            {
                mostrarDatos(m);
            }*/
            foreach(ResPartner partner in partners)
            {
                Console.WriteLine(partner.Name);
                Console.WriteLine(partner.Phone);
            }
            

            //Fin obtener aplicaciones ODOO
            Console.ReadLine();
        }

        public static void mostrarDatos(IrModuleModule m){
            //Mostrar datos del módulo "m"
            Console.WriteLine("////////////////////////");
            Console.WriteLine(m.Name);
            Console.WriteLine(m.Shortdesc);
            Console.WriteLine(m.Author);
            Console.WriteLine(m.Demo);
            Console.WriteLine(m.Web);
            Console.WriteLine("////////////////////////");
        }

        public string getContrasena(){
            return contrasena;
        }
    }
}
