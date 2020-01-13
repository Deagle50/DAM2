using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RetoODOONetCore.Models;

namespace RetoODOONetCore.Controllers
{

    List<CochesModel> ListaCoches = new List<CochesModel>(){
        new CochesModel {ID = 1, modelo = "Romeo", marca = "Alfalfa", matricula = "1234BCD"},
        new CochesModel {ID = 2, modelo = "Quietorl", marca = "Chiquito", matricula = "2345CDF"},
    };
    public class CochesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Prueba()
        {
            return Content("Hola");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
