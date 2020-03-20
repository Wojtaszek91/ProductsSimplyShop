using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimplyProductShop.ViewModel
{
    public class AboutMeViewModel    {
        public string WhoIAm { get; set; }
        [Required]
        public string WhatImIdoing { get; set; }
        public string MyExperience { get; set; }
    }
}