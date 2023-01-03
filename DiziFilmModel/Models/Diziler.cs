using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DiziFilmModel.Models
{
    public class Diziler
    {
        [Key]
        public int DiziID { get; set; }


        [StringLength(60), Required]
        public string DiziAdi { get; set; }


        [StringLength(60), Required]
        public string DiziTür { get; set; }


        [StringLength(60), Required]
        public string DiziGün { get; set; }


        [ForeignKey("Kanallar")]
        public int KanalID { get; set; }
        public virtual Kanallar Kanallar { get; private set; }
    
    }
}
