using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RetoODOONetCore.Models;
/// <summary>
/// 
/// </summary>
namespace RetoODOONetCore.Pages
{
    /// <summary>
    /// 
    /// </summary>
    public class IndexModel : PageModel
    {
        /// <summary>
        /// 
        /// </summary>
        public List<FleetVehicle> vehicles { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public void OnGet()
        {
            using (var contexto = new OdooDBContext())
            {
                vehicles = contexto.FleetVehicle.ToList();
            }
        }
    }
}
