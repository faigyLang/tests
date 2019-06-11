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
using testgit.Models;

namespace testgit.Controllers
{
    public class animalsController : ApiController
    {
        private testgitContext db = new testgitContext();

        // GET: api/animals
        public IQueryable<animals> Getanimals()
        {
            return db.animals;
        }

        // GET: api/animals/5
        [ResponseType(typeof(animals))]
        public IHttpActionResult Getanimals(int id)
        {
            animals animals = db.animals.Find(id);
            if (animals == null)
            {
                return NotFound();
            }

            return Ok(animals);
        }

        // PUT: api/animals/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putanimals(int id, animals animals)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != animals.Id)
            {
                return BadRequest();
            }

            db.Entry(animals).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!animalsExists(id))
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

        // POST: api/animals
        [ResponseType(typeof(animals))]
        public IHttpActionResult Postanimals(animals animals)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.animals.Add(animals);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = animals.Id }, animals);
        }

        // DELETE: api/animals/5
        [ResponseType(typeof(animals))]
        public IHttpActionResult Deleteanimals(int id)
        {
            animals animals = db.animals.Find(id);
            if (animals == null)
            {
                return NotFound();
            }

            db.animals.Remove(animals);
            db.SaveChanges();

            return Ok(animals);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool animalsExists(int id)
        {
            return db.animals.Count(e => e.Id == id) > 0;
        }
    }
}