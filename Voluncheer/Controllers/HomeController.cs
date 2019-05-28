using System.Web;
using System.Web.Mvc;

namespace Voluncheer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }

        public ActionResult DocumentRepository()
        {
            return View();
        }

        //public ActionResult Document(string name)
        //{
        //    string mimeType = MimeMapping.GetMimeMapping(name);
            
        //}
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your login page.";

            return View();
        }

      
    }
}