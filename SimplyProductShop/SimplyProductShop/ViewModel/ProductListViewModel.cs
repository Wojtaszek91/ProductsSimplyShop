﻿using SimplyProductShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimplyProductShop.ViewModel
{
    public class ProductListViewModel
    {
        public IEnumerable<ProductModel> ProductList { get; set; }
    }
}