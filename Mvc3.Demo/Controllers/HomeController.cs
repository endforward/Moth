﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moth.Core;

namespace Mvc3.Demo.Controllers
{
    [MothAction(OutputCaching = true)]
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OutputCaching()
        {
            return View();
        }


        public ActionResult CurrentDateTime()
        {
            return Content(DateTime.Now.ToString());
        }
    }
}
