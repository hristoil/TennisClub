using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TennisClub2.Models
{
    public class ResultViewModel
    {
        public virtual List<string> Users { get; set; }
        public string Result { get; set; }
        public string FirstUser { get; set; }
        public string SecondUser { get; set; }
    }
}