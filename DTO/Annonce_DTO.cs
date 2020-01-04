using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnnonceAPI.DTO
{
    public class Annonce_DTO
    {
        public Guid id { get; set; }
       

        public DateTime date { get; set; }

        public string cat { get; set; }

        public string aut { get; set; }

        public string inti { get; set; }

        public string desc { get; set; }

        public decimal? prix { get; set; }


    }
}