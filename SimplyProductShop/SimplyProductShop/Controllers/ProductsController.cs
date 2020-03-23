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
        // GET: Products
        public ViewResult Index()
        {
            return View();
        }
        //Get: Products/Details/{id}
        [Route("Details/{id}")]
        public ViewResult Details(int id)
        {
            var product = _context.ProductsModel.SingleOrDefault(c => c.Id == id);
            return View();
        }

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
    }
}