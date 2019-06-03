using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Voluncheer.Backend;

namespace Voluncheer.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult Index()
        {
            var model = EventBackend.Instance.Index();
            return View(model);
        }

        // GET: Event Details page
        public ActionResult Details(string id = null)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var eventModel = EventBackend.Instance.Read(id);
            return View(eventModel);
        }

        // GET: Create Event page
        public ActionResult Create()
        {
            return View();
        }
    }
}