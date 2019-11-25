using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using JsonProyecto1.Models;

namespace JsonProyecto1.Pages
{
    public class Test1Model : PageModel
    {

        public string Mensaje{get;set;}
        // public string nombre{get;set;}
        // public string apellido{get;set;}
        public List<empleado> empleados {get;set;} 
        public void OnGet()
        {
            Mensaje = "getting";
            empleados = new List<empleado>{
                new empleado(){
                    nombre="Jon",
                    apellido="Smith"
                },
                new empleado(){
                    nombre="Maria",
                    apellido="Fernández"
                }
            };
        }

        // public void OnPost(string nombre, string apellido)
        // {
        //     /*nombre = Request.Form["nombre"];
        //     apellido = Request.Form["apellido"];*/
        //     Mensaje = "posting" + " " + nombre + " " + apellido;
        // }
    }

}