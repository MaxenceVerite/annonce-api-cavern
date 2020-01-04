using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Http.Tracing;

namespace AnnonceAPI.DAL
{
    [Table("TBL_Plats")]
    public class Annonce_DAO
    {

        [Key]
        [Column(name:"PK_Plat")]
        public Guid Id { get; set; } = Guid.NewGuid();



        public DateTime Date { get; set; } = DateTime.Now;

        [Required]
        public string Categorie { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public string Auteur { get; set; }


        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Intitule { get; set; }

        
        [MaxLength(400)]
        public string Description { get; set; }


        [Range(0, int.MaxValue)]
        public decimal? Prix { get; set; }

    }
}