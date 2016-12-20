using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TennisClub2.Models;

namespace TennisClub2.Controllers
{
    public class ResultsController : Controller
    {
     
    
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            using (var Database = new BlogDbContext())
            {
                var Players = Database.Users.ToList();

                return View(Players);
            }
        }
    }
}