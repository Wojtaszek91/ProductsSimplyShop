using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimplyProductShop.Models
{
    public class Products
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string Img { get; set; }
        bool IsAvaliable { get; set; }
    }
}