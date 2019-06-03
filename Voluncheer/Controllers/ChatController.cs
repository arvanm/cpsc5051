using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Voluncheer.Backend;

namespace Voluncheer.Controllers
{
    public class ChatController : Controller
    {
        // GET: Chat
        public ActionResult Index()
        {
            return View();
        }

        // GET: DirectMessage
        public ActionResult DirectMessage(string id = null)
        {
            var chatModel = VolunteerBackend.Instance.Read(id).DirectMessageHistory;
            return View(chatModel);
        }

    }
}