using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimplyProductShop.Controllers
{
    public class HomeController : Controller
    {

        // Get: Index main page
        public ViewResult Index()
        {
            ViewBag.Message = "Strona poswiecona ...";
            return View();
        }

        // Get: About/edit *** Edit content of main page
        public ViewResult Edit()
        {

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}