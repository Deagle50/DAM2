using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RetoODOONetCore.Models;

namespace RetoODOONetCore.Pages
{
    public class IndexModel : PageModel
    {
        public List<FleetVehicle> vehicles { get; set; }
        public void OnGet()
        {
            using (var contexto = new OdooDBContext())
            {
                vehicles = contexto.FleetVehicle.ToList();
            }
        }
    }
}
