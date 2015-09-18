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
using TokenSystem.Models;

namespace TokenSystem.Controllers
{
    public class CampusController : ApiController
    {
        private TokenContext db = new TokenContext();

        // GET: api/Campus
        public IQueryable<Campus> GetCampuses()
        {
            return db.Campuses;
        }

        // GET: api/Campus/5
        [ResponseType(typeof(Campus))]
        public IHttpActionResult GetCampus(int id)
        {
            Campus campus = db.Campuses.Find(id);
            if (campus == null)
            {
                return NotFound();
            }

            return Ok(campus);
        }

        // PUT: api/Campus/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCampus(int id, Campus campus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != campus.Campusid)
            {
                return BadRequest();
            }

            db.Entry(campus).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CampusExists(id))
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

        // POST: api/Campus
        [ResponseType(typeof(Campus))]
        public IHttpActionResult PostCampus(Campus campus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Campuses.Add(campus);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = campus.Campusid }, campus);
        }

        // DELETE: api/Campus/5
        [ResponseType(typeof(Campus))]
        public IHttpActionResult DeleteCampus(int id)
        {
            Campus campus = db.Campuses.Find(id);
            if (campus == null)
            {
                return NotFound();
            }

            db.Campuses.Remove(campus);
            db.SaveChanges();

            return Ok(campus);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CampusExists(int id)
        {
            return db.Campuses.Count(e => e.Campusid == id) > 0;
        }
    }
}