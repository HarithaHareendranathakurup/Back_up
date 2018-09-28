using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Authorisation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult SecureMethod()
        {
            return View();
        }

        public ActionResult NonSecureMethod()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

     
    }
}