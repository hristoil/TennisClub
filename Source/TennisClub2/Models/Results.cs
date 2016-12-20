using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TennisClub2.Models
{
    public class Results
    {
        public virtual ApplicationUser firstPlayer { get; set; }

        public virtual ApplicationUser secondPlayer { get; set; }

        [Key]
        public string results { get; set; }


    }
}