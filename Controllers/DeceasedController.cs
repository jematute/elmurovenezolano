using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ElMuroVenezolano;
using ElMuroVenezolano.Models;

namespace ElMuroVenezolano.Controllers
{
    public class DeceasedController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: api/Deceased
        public IQueryable<Deceased> GetDeceased()
        {
            return db.Deceased;
        }

        //GET: api/Deceased
        public IHttpActionResult GetDeceasedByState(State state)
        {
            var deceased = (from d in db.Deceased
                            where d.DeathState == state
                            select d).ToList();
            return Ok(deceased);
            
        }


        // GET: api/Deceased/5
        [ResponseType(typeof(Deceased))]
        public IHttpActionResult GetDeceased(int id)
        {
            Deceased deceased = db.Deceased.Find(id);
            if (deceased == null)
            {
                return NotFound();
            }

            return Ok(deceased);
        }

        // PUT: api/Deceased/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDeceased(int id, Deceased deceased)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != deceased.Id)
            {
                return BadRequest();
            }

            db.Entry(deceased).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeceasedExists(id))
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

        // POST: api/Deceased
        [ResponseType(typeof(Deceased))]
        public IHttpActionResult PostDeceased(Deceased deceased)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Deceased.Add(deceased);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = deceased.Id }, deceased);
        }

        // DELETE: api/Deceased/5
        [ResponseType(typeof(Deceased))]
        public IHttpActionResult DeleteDeceased(int id)
        {
            Deceased deceased = db.Deceased.Find(id);
            if (deceased == null)
            {
                return NotFound();
            }

            db.Deceased.Remove(deceased);
            db.SaveChanges();

            return Ok(deceased);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DeceasedExists(int id)
        {
            return db.Deceased.Count(e => e.Id == id) > 0;
        }
    }
}