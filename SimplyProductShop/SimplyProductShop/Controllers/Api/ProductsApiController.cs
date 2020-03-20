using SimplyProductShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimplyProductShop.Controllers.Api
{
    public class ProductsApiController : ApiController
    {
        private ApplicationDbContext _context;

        public ProductsApiController()
        {
            _context = new ApplicationDbContext();
        }

        // Get: api/products
        //public IEnumerable<Product> GetProducts()
        //{
        //    return _context.Products.ToList();
        //}

        //// Get: api/products/1
        //public Product GetProduct(int id)
        //{
        //    if(_context)
        //}
    }
}
