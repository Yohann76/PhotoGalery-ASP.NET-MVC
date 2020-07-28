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
        // return viex "index" , in RouteConfig.cs 
        public ActionResult Index()
        {
            return View();
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



        public ActionResult ListCategories()
        {
            Categories categories = new Categories();
            ViewData["Categories"] = categories.GetListCategories();
            return View();
        }

        public ActionResult SearchCategory(string id)
        {
            ViewData["Name"] = id;
            Categories categories = new Categories();
            Category category = categories.GetListCategories().FirstOrDefault(c => c.Name == id);
            if (category != null)
            {
                ViewData["Name"] = category.Name;
                ViewData["Years"] = category.Years;
                return View("Category");
            }
            return View("CategoryNotFound");
        }


    }
}