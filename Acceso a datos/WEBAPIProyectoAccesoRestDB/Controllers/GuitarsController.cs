using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPIProyectoAccesoRestDB.Models;

namespace WEBAPIProyectoAccesoRestDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuitarsController : ControllerBase
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

        // GET: api/Guitars
        [HttpGet]
        public IEnumerable<Guitarra> Get()
        {
            return listaGuitarras.ToList();
        }

        // GET: api/Guitars/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Guitarra> Get(int id)
        {
            return listaGuitarras.ElementAt(id);
        }

        // POST: api/Guitars
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Guitars/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
