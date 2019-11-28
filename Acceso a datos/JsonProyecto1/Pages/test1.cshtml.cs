using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using JsonProyecto1.Models;

namespace JsonProyecto1.Pages
{
    public class companyModel : PageModel
    {

        public List<company> compania {get;set;} 
        public void OnGet()
        {
            compania = new List<company>{
                new company(){
                    name="compañia1",
                    address="direccion1",
                    description="descripcion1",
                    type="tipo1",
                    employees=14,
                    contacts="contacto1",
                    oportunities="oportunidad1"
                },
                new company(){
                    name="compañia2",
                    address="direccion2",
                    description="descripcion2",
                    type="tipo2",
                    employees=435,
                    contacts="contacto2",
                    oportunities="oportunidad2"
                },
                new company(){
                    name="compania3",
                    address="dirección3",
                    description="descripcion3",
                    type="tipo3",
                    employees=32479,
                    contacts="contacto3",
                    oportunities="oportunidad3",
                }
            };
        }

        // public void OnPost(string nombre, string apellido)
        // {
        //     /*nombre = Request.Form["nombre"];
        //     apellido = Request.Form["apellido"];*/
        //     Mensaje = "posting" + " " + nombre + " " + apellido;
        // }
        // new company(){
        //             name="",
        //             address="",
        //             description="",
        //             type="",
        //             employees=,
        //             contacts="",
        //             oportunities="",
        //         }
    }

}