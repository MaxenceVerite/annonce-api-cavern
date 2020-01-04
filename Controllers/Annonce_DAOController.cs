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
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using AnnonceAPI.DAL;

namespace AnnonceAPI.Controllers
{
    /*
    La classe WebApiConfig peut exiger d'autres modifications pour ajouter un itinéraire à ce contrôleur. Fusionnez ces instructions dans la méthode Register de la classe WebApiConfig, le cas échéant. Les URL OData sont sensibles à la casse.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using AnnonceAPI.DAL;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Annonce_DAO>("Annonce_DAO");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */

    public class Annonce_DAOController : ODataController
    {
        private AnnoncesContext db = new AnnoncesContext();


        // GET: odata/Annonce_DAO
        [EnableQuery]
        public IQueryable<Annonce_DAO> GetAnnonce_DAO()
        {
            return db.Annonces;
        }

        // GET: odata/Annonce_DAO(5)
        [EnableQuery]
        public SingleResult<Annonce_DAO> GetAnnonce_DAO([FromODataUri] Guid key)
        {
            return SingleResult.Create(db.Annonces.Where(annonce_DAO => annonce_DAO.Id == key));
        }

        // PUT: odata/Annonce_DAO(5)
        public IHttpActionResult Put([FromODataUri] Guid key, Delta<Annonce_DAO> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Annonce_DAO annonce_DAO = db.Annonces.Find(key);
            if (annonce_DAO == null)
            {
                return NotFound();
            }

            patch.Put(annonce_DAO);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Annonce_DAOExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(annonce_DAO);
        }

        // POST: odata/Annonce_DAO
        public IHttpActionResult Post(Annonce_DAO annonce_DAO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Annonces.Add(annonce_DAO);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (Annonce_DAOExists(annonce_DAO.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Created(annonce_DAO);
        }

        // PATCH: odata/Annonce_DAO(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] Guid key, Delta<Annonce_DAO> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Annonce_DAO annonce_DAO = db.Annonces.Find(key);
            if (annonce_DAO == null)
            {
                return NotFound();
            }

            patch.Patch(annonce_DAO);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Annonce_DAOExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(annonce_DAO);
        }

        // DELETE: odata/Annonce_DAO(5)
        public IHttpActionResult Delete([FromODataUri] Guid key)
        {
            Annonce_DAO annonce_DAO = db.Annonces.Find(key);
            if (annonce_DAO == null)
            {
                return NotFound();
            }

            db.Annonces.Remove(annonce_DAO);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Annonce_DAOExists(Guid key)
        {
            return db.Annonces.Count(e => e.Id == key) > 0;
        }
    }
}
