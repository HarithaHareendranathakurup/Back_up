using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyEvent()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult CreateEvent()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}