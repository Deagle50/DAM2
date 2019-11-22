using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JsonProyecto1.Pages
{
    public class EmpleadosModel : PageModel
    {
        public int IdEmpleado {get;set;}

        public string Nombre {get;set;}

        public string Apellido {get;set;}

        public decimal Salario{get;set;}

        public void OnGet(){
            IdEmpleado = 1;
            Nombre = "Juan";
            Apellido = "Fernández";
            Salario = 500000;
        }
        
    }

}