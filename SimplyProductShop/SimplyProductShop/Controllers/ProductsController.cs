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
    public class ProductsController : Controller
    {
        private ApplicationDbContext _context;

        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Index
        // return main product view
        public ViewResult Index()
        {
            return View();
        }

        // GET: return view with product Form, if passed with correct Id return form with existing values 
        public ViewResult SaveProductForm(int? id)
        {            
            if (id.HasValue) {
                var productInDb = _context.ProductsModel.SingleOrDefault(c => c.Id == id);
                if (productInDb != null)
                {
                    var productView = Mapper.Map<Product, ProductViewModel>(productInDb);
                    return View(productView);
                }
            };
            return View();
        }

        // POST: Save Product in Db
        // If not found in db create new one, if exist update values
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save([Bind(Exclude = "Id")] ProductViewModel productForDb)
        {
            if (!ModelState.IsValid)
            {
                return View("SaveProductForm", productForDb);
            }

            if (productForDb.Id == 0)
                _context.ProductsModel.Add(Mapper.Map<ProductViewModel,Product>(productForDb));
            else
            {
                var productInDb = _context.ProductsModel.Single(p => p.Id == productForDb.Id);
                Mapper.Map(productForDb, productInDb);
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Products");
        }

        // GET: Products/Details/id
        public ActionResult Details(int id)
        {
            var productInDb = _context.ProductsModel.SingleOrDefault(c => c.Id == id);

            if (productInDb == null)
                return HttpNotFound();
            var productView = Mapper.Map<Product, ProductViewModel>(productInDb);
            return View(productView);
        }
    }
}