﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomAuthorization.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [CustomAuthorize(Users="haritha@gmail.com")]
        public ActionResult About()
        {
                ViewBag.Message = "Your application description page.";

                return View();
            
        }
        [CustomAuthorize(Users = "monisha@gmail.com")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}