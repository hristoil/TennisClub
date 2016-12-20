using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Routing;
using System.Web.Mvc;
using TennisClub2.Controllers;

namespace TennisClub2.Models
{
    public class TennisLessons
    {
        [Key]
        public string tennisLessons { get; set; }
    }
}