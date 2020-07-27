using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhotoGalery.Controllers
{
    public class HomeController : Controller
    {
        /*
        public ActionResult Index()
        {
            return View();
        }
        */

        // return Hello World
        public string Index()
        {
            return "Hello World MVC, press F5 for result";
        }

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
    }
}