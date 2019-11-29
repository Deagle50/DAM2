
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoAccesoRestDBAPI.Models;

namespace WebApp1Acceso.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private Guitarra guitarra = new Guitarra();
        private List<Guitarra> listaGuitarras = new List<Guitarra>(){
            new Guitarra {
                
                id_guitarra = 1,
                nombre = "Squier Bullet Strat",
                marca="Fender Squier",
                forma="Stratocaster",
                pastillas="HSS",
                color="Arctic White",
                precio=125F,
            },
            new Guitarra {
                id_guitarra = 2,
                nombre = "Epiphone Les Paul 1959",
                marca="Epiphone",
                forma="Les Paul Single Cut",
                pastillas="HH",
                color="Sunburst",
                precio=1800F,
            },
            new Guitarra {
                id_guitarra = 3,
                nombre = "Gibson SG Angus Young Signature",
                marca="Gibson",
                forma="SG Double Cut",
                pastillas="HH",
                color="Cherry Red",
                precio=2200F,
            },
        };
                
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Guitarra>> Get()
        {            
            return listaGuitarras.Where(p=>p.precio>50F).ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Guitarra> Get(int i)
        {
            return listaGuitarras.ElementAt(i);
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
