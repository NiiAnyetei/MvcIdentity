﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIdentity.Controllers
{
    [Authorize]
    public class AppController : Controller
    {
        // GET: App
        public ActionResult Dashboard()
        {

            return View();
        }
    }
}