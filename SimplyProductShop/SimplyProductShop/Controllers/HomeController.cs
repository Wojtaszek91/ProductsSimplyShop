using SimplyProductShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimplyProductShop.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // Get: Index main page
        public ViewResult Index()
        {
            return View(_context.AboutMeModels.SingleOrDefault(c=> c.id==1));
        }

        // Get: About/edit *** From to edit AboutMe content
        public ViewResult EditAbout()
        {
            return View();
        }

        // Post:  Update About(HomePage) content
        [HttpPost]
        public RedirectToRouteResult SumbitAboutEditForm(AboutMeModel about)
        {
            var aboutDb = _context.AboutMeModels.SingleOrDefault(m => m.id == 1);
            aboutDb.WhoIAm = about.WhoIAm;
            aboutDb.WhatImIdoing = about.WhatImIdoing;
            aboutDb.MyExperience = about.MyExperience;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}