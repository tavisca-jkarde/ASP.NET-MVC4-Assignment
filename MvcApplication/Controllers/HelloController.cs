﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication.Controllers
{
    public class HelloController : Controller
    {
        //
        // GET: /Hello/

        public ActionResult Index()
        {
            return View();

        }
        //
        // GET: /Hello/Welcome/

        public ActionResult Welcome(string name, int numTimes = 1) {

            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();



        }

    }
}
