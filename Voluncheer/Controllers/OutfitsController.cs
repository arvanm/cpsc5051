using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Voluncheer.Models;
using Voluncheer.Backend;

namespace Voluncheer.Controllers
{
    public class OutfitsController : Controller
    {
        // GET: Outfits
        public ActionResult Index()
        {
            var model = OutfitBackend.Instance.Index();
            return View(model);
        }

        public ActionResult Read(string outfitName)
        {
            var outfit = OutfitBackend.Instance.Read(outfitName);
            return View(outfit);
        }
    }
}