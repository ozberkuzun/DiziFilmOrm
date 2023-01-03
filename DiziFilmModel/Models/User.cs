using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DiziFilmModel.Models
{
   public class User
    {
        [Key]
        public int UserID { get; set; }


        [StringLength(60), Required]
        public string UserAdi { get; set; }


        [StringLength(60), Required]
        public string UserSifre { get; set; }
    }
}
