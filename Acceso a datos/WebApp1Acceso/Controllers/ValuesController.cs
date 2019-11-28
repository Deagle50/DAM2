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
    public class ValuesController : ControllerBase
    {
        private Persona persona1 = new Persona();
        private List<Persona> listaPersonas = new List<Persona>(){
            new Persona {
                
                id_persona = 1,
                nombre = "Nombre1",
                apellido="apellido1"
            },
            new Persona {
                id_persona = 2,
                nombre = "Nombre2",
                apellido="apellido2"
            },
            new Persona {
                id_persona = 3,
                nombre = "Nombre3",
                apellido="apellido3"
            },
        };
        private string[] frutas= {"manzana", "platano", "mango"};
        private int[] numeros={1,2,3,4,5,6,7,8,9};
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Persona>> Get()
        {
            return listaPersonas.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Persona> Get(String id)
        {
            return listaPersonas.Where(p=>p.nombre==id).First();
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
