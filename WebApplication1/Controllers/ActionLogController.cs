﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Filters;

namespace WebApplication1.Controllers
{
    [CustomActionFilter]
    public class ActionLogController : Controller
    {
        // GET: ActionLog
        public ActionResult Index()
        {
            return View();
        }
    }
}