using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimplyProductShop.ViewModel
{
    public class ProductViewModel
    {
        [Key]
        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Img { get; set; }

        [Required]
        public bool IsAvaliable { get; set; }

        public string Category { get; set; }
    }
}