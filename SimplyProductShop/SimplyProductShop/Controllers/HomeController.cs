using AutoMapper;
using SimplyProductShop.Models;
using SimplyProductShop.ViewModel;
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
          var aboutDbModel =  _context.AboutMeModels.SingleOrDefault(c => c.id == 1);
            var aboutViewModel = Mapper.Map<AboutMeModel,AboutMeViewModel>(aboutDbModel);
            return View(aboutViewModel);
        }

        // Get: About/edit *** From to edit AboutMe content
        public ViewResult EditAbout()
        {
            return View();
        }

        // Post:  Update About(HomePage) content
        [HttpPost]
        public RedirectToRouteResult SumbitAboutEditForm(AboutMeViewModel about)
        {
            var aboutDb = _context.AboutMeModels.SingleOrDefault(m => m.id == 1);
            Mapper.Map(about,aboutDb);
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