using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using AplicacionWebFrameworkConEntityFramework;

namespace AplicacionWebFrameworkConEntityFramework.Controllers
{
    public class GuitarrasController : ApiController
    {
        private DAM_urkourbieta_DEVEntities db = new DAM_urkourbieta_DEVEntities();

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // GET: api/Guitarras
        public IQueryable<Guitarras> GetGuitarras()
        {
            return db.Guitarras;
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // GET: api/Guitarras/5
        [ResponseType(typeof(Guitarras))]
        public IHttpActionResult GetGuitarras(int id)
        {
            Guitarras guitarras = db.Guitarras.Find(id);
            if (guitarras == null)
            {
                return NotFound();
            }

            return Ok(guitarras);
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // PUT: api/Guitarras/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGuitarras(int id, Guitarras guitarras)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != guitarras.id_guitarra)
            {
                return BadRequest();
            }

            db.Entry(guitarras).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GuitarrasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // POST: api/Guitarras
        [ResponseType(typeof(Guitarras))]
        public IHttpActionResult PostGuitarras(Guitarras guitarras)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Guitarras.Add(guitarras);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (GuitarrasExists(guitarras.id_guitarra))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = guitarras.id_guitarra }, guitarras);
        }

        // DELETE: api/Guitarras/5
        [EnableCors(origins:"*", headers:"*", methods:"*")]
        [ResponseType(typeof(Guitarras))]
        public IHttpActionResult DeleteGuitarras(int id)
        {
            Guitarras guitarras = db.Guitarras.Find(id);
            if (guitarras == null)
            {
                return NotFound();
            }

            db.Guitarras.Remove(guitarras);
            db.SaveChanges();

            return Ok(guitarras);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GuitarrasExists(int id)
        {
            return db.Guitarras.Count(e => e.id_guitarra == id) > 0;
        }
    }
}