using AutoMapper;
using SimplyProductShop.Models;
using SimplyProductShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimplyProductShop.Controllers.Api
{
    public class ProductsController : ApiController
    {
        private ApplicationDbContext _context;

        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }

        // Get: api/products
        public IEnumerable<Product> GetProducts()
        {
            return _context.ProductsModel.ToList();
        }

        // Get: api/products/1
        public ProductViewModel GetProduct(int id)
        {
          var productInDb =  _context.ProductsModel.SingleOrDefault(p => p.Id == id);
            if (productInDb == null) throw new HttpResponseException(HttpStatusCode.NotFound);
           var productViewModel = Mapper.Map<Product, ProductViewModel>(productInDb);
            return productViewModel;
        }

        //Post: api/products
        [HttpPost]
        [Authorize(Roles = RoleName.CanManageProducts)]
        public ProductViewModel PostProduct(ProductViewModel product)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            _context.ProductsModel.Add(Mapper.Map<ProductViewModel, Product>(product));
            _context.SaveChanges();
            return product;
        }

        //PUT: api/products/1
        [HttpPut]
        [Authorize(Roles = RoleName.CanManageProducts)]
        public void UpdateProduct(int id, ProductViewModel product)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var productInDb =_context.ProductsModel.SingleOrDefault(p => p.Id == id);
            if (productInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            else
            {
                Mapper.Map(product, productInDb);
                _context.SaveChanges();
            }
        }

        //DELETE: api/products/1
        [Authorize(Roles = RoleName.CanManageProducts)]
        public void DeleteProduct(int id)
        {
            var productInDb = _context.ProductsModel.SingleOrDefault(p => p.Id == id);
            if (productInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.ProductsModel.Remove(productInDb);
            _context.SaveChanges();
        }
    }
}
