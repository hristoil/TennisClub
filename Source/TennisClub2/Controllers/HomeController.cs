using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TennisClub2.Models;

namespace TennisClub2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Players()
        {
            ViewBag.Message = "Сайт за фенове на тениса";
            using (var Database = new BlogDbContext())
            {
                var Players = Database.Users.ToList();

                return View(Players);
            }
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Обичате тениса? Свържете се с нас!!!";

            return View();
        }

        public ActionResult Clubs()
        {
            return View();
        }

        public ActionResult Results()
        {
            using (var Database = new BlogDbContext())
            {
                var Names = Database.Users.ToList();
                return View(Names);
            }
        }
        
        // GET: TennisLessons
        public ActionResult TennisLessons()
        {
            return View();
        }

    }
}
