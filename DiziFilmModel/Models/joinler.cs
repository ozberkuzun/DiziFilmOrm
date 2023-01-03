using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DiziFilmModel.Models
{
   public class joinler
    {
        [Key]
        public int SorguNo { get; set; }
        public Kanallar kanallar { get; set; }
        public Diziler diziler { get; set; }
        public Oyuncular oyuncular { get; set; }

    }
}
