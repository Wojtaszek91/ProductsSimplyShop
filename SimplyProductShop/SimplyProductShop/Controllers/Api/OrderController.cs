﻿using SimplyProductShop.Dto;
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

        [HttpPost]
        public IHttpActionResult MakeOrder(OrderDto order)
        {

            _context.OrderModels.Add(new OrderModel()
            {
                customer = _context.Customers.Single(c => c.Id == order.CustomerId),
                productsList = _context.ProductsModel.Where(p => order.ProductsIdList.Contains(p.Id)).ToList(),
                orderDate = DateTime.Now
            });

            _context.SaveChanges();
            
            return Ok();
        }


    }
}