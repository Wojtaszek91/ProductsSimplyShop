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
            var productList = _context.ProductsModel.ToList(); 
            return View(new ProductListViewModel { ProductList = productList});
        }
        //Get: Products/Details
        public ViewResult Details(int id)
        {
            return View();
        }
    }
}