using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RetoOdooNC2.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RetoOdooNC2.Pages
{
    public class IndexModel : PageModel
    {
        public List<FleetVehicle> coches { get; set; }
        public void OnGet()
        {
            using (var context = new OdooDBContext())
            {
                coches = context.FleetVehicle.ToList();
                
            }
        }
    }
}
