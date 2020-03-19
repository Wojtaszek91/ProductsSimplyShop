using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SimplyProductShop.Models
{
    public class AboutMeModel
    {
        [Required]
        string WhoIam { get; set; }
        [Required]
        string WhatImIdoing { get; set; }
        string MyExperience { get; set; }
    }
}