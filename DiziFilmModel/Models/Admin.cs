using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DiziFilmModel.Models
{
   public class Admin
    {
        [Key]
        public int AdminID { get; set; }


        [StringLength(60), Required]
        public string AdminAdi { get; set; }


        [StringLength(60), Required]
        public string AdminSifre { get; set; }
    }
}
