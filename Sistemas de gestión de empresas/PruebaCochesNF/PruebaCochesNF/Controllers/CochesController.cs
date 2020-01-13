using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebaCochesNF.Models;

namespace PruebaCochesNF.Controllers
{
    public class CochesController : Controller
    {
        List<Coches> lista = new List<Coches>()
        {
            new Coches{ marca = "Hierroari", modelo="Chindasvinto", ID=1, matricula="1234BCD"}
        };
        // GET: Coches
        public ActionResult Index()
        {
            return View(lista);
        }

        // GET: Coches/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Coches/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Coches/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Coches/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Coches/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Coches/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Coches/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
