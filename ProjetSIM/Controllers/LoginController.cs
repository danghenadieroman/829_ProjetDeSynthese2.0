using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetSIM.Controllers
{
    public class LoginController : Controller
    {
        // retoune la vue login
        public ActionResult Login()
        {
           
            return View();
        }

        // retoune la vue login
        public ActionResult SeConnecter()
        {
            return View();
        }
    }
}