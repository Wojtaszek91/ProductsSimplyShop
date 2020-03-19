using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SimplyProductShop.Models
{
    public class AboutMeModel
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string WhoIAm { get; set; }
        [Required]
        public string WhatImIdoing { get; set; }
        public string MyExperience { get; set; }
    }
}