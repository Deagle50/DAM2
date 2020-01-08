using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCProyecto1.Models;

namespace MVCProyecto1.Controllers
{
    public class PersonasController : Controller
    {
        public IActionResult Index()
        {
            return Content("Aquí está mi controlador");
        }

        public IActionResult Prueba1()
        {
            return Content("Prueba1");
        }

    }
}
