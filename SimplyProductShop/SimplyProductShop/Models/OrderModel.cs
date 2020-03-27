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
        public int Id { get; set; }
        public Customer customer { get; set; }
        public Product product { get; set; }
        [Required]
        public DateTime orderDate { get; set; }
        public DateTime deliveredDate { get; set; }
        public DateTime payedDate { get; set; }
        public bool isPayed { get; set; }
        public bool isDelivered { get; set; }
    }
}