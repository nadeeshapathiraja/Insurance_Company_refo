﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBMS.Web.MVC.Security;

namespace IBMS.Web.MVC.Controllers
{
    public class EmailController : Controller
    {
        [CustomAuthorize(menu = 43)]
        public ActionResult EmailSend()
        {
            return View();
        }
    }
}