﻿using IBMS.Web.MVC.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IBMS.Web.MVC.Controllers
{
    public class IntegrationController : Controller
    {
        // GET: Integration
        [CustomAuthorize(menu = 78)]
        public ActionResult Index()
        {
            return View();
        }
    }
}