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
using API1.Models;

namespace API1.Controllers
{
    public class UsuariosController : ApiController
    {
        private IDGS01_Api1Entities db = new IDGS01_Api1Entities();

        // GET: api/Usuarios
        public IQueryable<DbUsuario> GetDbUsuario()
        {
            return db.DbUsuario;
        }

        // GET: api/Usuarios/5
        [ResponseType(typeof(DbUsuario))]
        public IHttpActionResult GetDbUsuario(int id)
        {
            DbUsuario dbUsuario = db.DbUsuario.Find(id);
            if (dbUsuario == null)
            {
                return NotFound();
            }

            return Ok(dbUsuario);
        }

        // PUT: api/Usuarios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDbUsuario(int id, DbUsuario dbUsuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dbUsuario.Id)
            {
                return BadRequest();
            }

            db.Entry(dbUsuario).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DbUsuarioExists(id))
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

        // POST: api/Usuarios
        [ResponseType(typeof(DbUsuario))]
        public IHttpActionResult PostDbUsuario(DbUsuario dbUsuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DbUsuario.Add(dbUsuario);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dbUsuario.Id }, dbUsuario);
        }

        // DELETE: api/Usuarios/5
        [ResponseType(typeof(DbUsuario))]
        public IHttpActionResult DeleteDbUsuario(int id)
        {
            DbUsuario dbUsuario = db.DbUsuario.Find(id);
            if (dbUsuario == null)
            {
                return NotFound();
            }

            db.DbUsuario.Remove(dbUsuario);
            db.SaveChanges();

            return Ok(dbUsuario);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DbUsuarioExists(int id)
        {
            return db.DbUsuario.Count(e => e.Id == id) > 0;
        }
    }
}