﻿using IBMS.Web.MVC.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IBMS.Web.MVC.Controllers
{
    public class PolicyInformationRecordingController : Controller
    {
        [CustomAuthorize(menu = 30)]
        public ActionResult Index()
        {
            return View();
        }
    }
}