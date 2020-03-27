using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimplyProductShop.Models
{
    public class OrderModel
    {
        [Required]
        public DateTime orderDate;
        public bool isPayed;
        public bool isDelivered;
    }
}