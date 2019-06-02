using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Voluncheer.Models;

namespace Voluncheer.Controllers
{
    public class OutfitsController : Controller
    {
        // GET: Outfits
        public ActionResult Index()
        {
            OutfitViewModel dataset = new OutfitViewModel();
            return View(dataset);
        }
    }
}