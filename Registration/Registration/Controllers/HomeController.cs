using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registration.Models;

namespace Registration.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(tblRegistration obj)

        {
            if (ModelState.IsValid)
            {
                dbEntities d = new dbEntities();
                d.tblRegistrations.Add(obj);
               // d.SaveChanges();
            }
            return View(obj);
        }
    }
}