using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Voluncheer.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult Index()
        {
            return View();
        }

        // GET: Event Details page
        public ActionResult Details()
        {
            return View();
        }
    }
}