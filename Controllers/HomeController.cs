using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhotoGalery.Models;



namespace PhotoGalery.Controllers
{
    public class HomeController : Controller
    {
        // return view "index" , in RouteConfig.cs 
        public ActionResult Index()
        {
            return View();
        }
    }
}