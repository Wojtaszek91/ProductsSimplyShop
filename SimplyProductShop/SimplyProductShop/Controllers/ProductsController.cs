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
        public ViewResult Index()
        {
            return View();
        }



        public ViewResult SaveProductForm(int? id)
        {
            if (!ModelState.IsValid)
            {
                
            }
            
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

        [HttpPost]
        public ActionResult Save(ProductViewModel productForDb)
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