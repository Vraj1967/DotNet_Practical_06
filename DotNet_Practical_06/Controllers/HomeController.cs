
using System.Web.Mvc;
using System.Web;
using System.Web.Helpers;
using System.Diagnostics;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Privacy()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}
