using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StaticWebSiteMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [Route("hakkimizda")]
        public ActionResult About()
        {
            return View();
        }

        [Route("blog")]
        public ActionResult Blog()
        {
            return View();
        }

        [Route("iletisim")]
        public ActionResult Contact()
        {
            return View();
        }
    }
}