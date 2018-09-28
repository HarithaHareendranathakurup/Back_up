using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Models;

namespace Application.Controllers
{
    public class HController : Controller
    {
        // GET: H
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Table1 ob)

        {
            if (ModelState.IsValid)
            {
                dbEntities o = new dbEntities();
                //db = new RegMVCEntities();
                o.Table1.Add(ob);
                o.SaveChanges();
            }
            return View(ob);
        }
    }
}