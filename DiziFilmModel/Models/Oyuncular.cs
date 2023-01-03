using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DiziFilmModel.Models
{
    public class Oyuncular
    {
        [Key]
        public int OyuncuID { get; set; }


        [StringLength(60), Required]
        public string OyuncuAdi { get; set; }


        [Required]
        public int OyuncuYas { get; set; }


        [StringLength(60), Required]
        public string OyuncuCinsiyet { get; set; }


        [ForeignKey("Diziler")]
        public int DiziID { get; set; }
        public virtual Diziler Diziler { get; private set; }

        
    }
}
