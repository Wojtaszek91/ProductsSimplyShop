using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimplyProductShop.Models
{
    public class Customer
    { 
        [Required]
        int Id { get; set; }
    }
}