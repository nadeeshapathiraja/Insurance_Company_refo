﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IBMS.Web.MVC.Controllers
{
    public class AuthorizeController : Controller
    {
        // GET: Authorize
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CheckAuthentication()
        {
            return View();
        }
    }
}