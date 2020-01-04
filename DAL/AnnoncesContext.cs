using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AnnonceAPI.DAL
{
    public class AnnoncesContext : DbContext 
    {
        static AnnoncesContext()
        {
         
            Database.SetInitializer(new AnnoncesInitializer());
        }

        public DbSet<Annonce_DAO> Annonces { get; set; }
    }
}