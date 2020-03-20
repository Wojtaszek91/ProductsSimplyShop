﻿using SimplyProductShop.Models;
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
        //Get: Products/Details/{id}
        [Route("Details/{id}")]
        public ViewResult Details(int id)
        {
            var product = _context.ProductsModel.SingleOrDefault(c => c.Id == id);
            return View();
        }

        [Route("SaveProductForm/{id}")]
        public ViewResult SaveProductForm(int? id)
        {
            if (id == 0) id = 2;
            var product = _context.ProductsModel.SingleOrDefault(c => c.Id == id);
            if (product != null)
                return View(product);
            else return View();
        }
    }
}