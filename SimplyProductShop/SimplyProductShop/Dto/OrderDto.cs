using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimplyProductShop.Dto
{
    public class OrderDto
    {
        public int CustomerId;
        public List<int> ProductsIdList;
    }
}