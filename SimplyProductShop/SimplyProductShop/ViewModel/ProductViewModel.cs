using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimplyProductShop.ViewModel
{
    public class ProductViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Img { get; set; }

        public bool IsAvaliable { get; set; }
        public string Category { get; set; }
    }
}