using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DiziFilmModel.Models
{
    public class Kanallar
    {
        [Key]
        public int KanalID { get; set; }


        [StringLength(60), Required]
        public string KanalAdi { get; set; }


        [StringLength(60), Required]
        public string KanalSahibi { get; set; }


        [StringLength(4), Required]
        public string KurulusYili { get; set; }

        


    }
}
