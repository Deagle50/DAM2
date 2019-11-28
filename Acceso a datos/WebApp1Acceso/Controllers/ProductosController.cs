using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp1Acceso.Models;

namespace WebApp1Acceso.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private Producto producto = new Producto();
        private List<Producto> listaProductos = new List<Producto>(){
            new Producto {
                
                id_producto = 1,
                nombre = "Nombre1",
                descripcion="Descripcion1",
                precio=1.23F,
            },
            new Producto {
                id_producto = 3,
                nombre = "Nombre2",
                descripcion="Descripcion2",
                precio=2.46F,
            },
            new Producto {
                id_producto = 60,
                nombre = "Nombre3",
                descripcion="Descripcion3",
                precio=3.69F,
            },
        };
                
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Producto>> Get()
        {            
            return listaProductos.Where(p=>p.precio>50F).ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Producto> Get(int i)
        {
            return listaProductos.ElementAt(i);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
