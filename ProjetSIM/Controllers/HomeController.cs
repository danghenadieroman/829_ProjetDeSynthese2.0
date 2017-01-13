using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetSIM.Models;

namespace ProjetSIM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
            //test3

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var db = DbContextSIM.getInstance();
            var utilisateurs = from u in db.Utilisateurs
                               select u;
            return View(utilisateurs);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}