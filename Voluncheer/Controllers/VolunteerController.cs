﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Voluncheer.Controllers
{
    public class VolunteerController : Controller
    {
        // GET: Volunteer
        public ActionResult Index()
        {
            return View();
        }
    }
}