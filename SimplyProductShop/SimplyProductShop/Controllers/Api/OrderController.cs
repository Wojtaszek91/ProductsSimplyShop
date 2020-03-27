using SimplyProductShop.Dto;
using SimplyProductShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimplyProductShop.Controllers.Api
{
    public class OrderController : ApiController
    {
        private ApplicationDbContext _context;

        public OrderController()
        {
            _context = new ApplicationDbContext();
        }

        // Checking edges cases and making an order in Db or send back bad request with message what happend.
        [HttpPost]
        public IHttpActionResult MakeOrder(OrderDto order)
        {
            if (order.ProductsIdList.Count() == 0)
                return BadRequest("No products found.");
            if (order.CustomerId == 0)
                return BadRequest("No customer found.");

            var productList = _context.ProductsModel.Where(p => order.ProductsIdList.Contains(p.Id)).ToList();

            if (productList.Count() != order.ProductsIdList.Count())
                return BadRequest("Not all products has been found.");

            foreach (var product in productList) {
                if (product.IsAvaliable == false)
                    return BadRequest("Product is not availabel !");

                var orderForDb = new OrderModel()
                {
                    customer = _context.Customers.Single(c => c.Id == order.CustomerId),
                    product = product,
                    orderDate = DateTime.Now
                };
                _context.OrderModels.Add(orderForDb);
            }

            _context.SaveChanges();
            
            return Ok();
        }
    }
}
