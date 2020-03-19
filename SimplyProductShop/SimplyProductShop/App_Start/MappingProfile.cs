using AutoMapper;
using SimplyProductShop.Models;
using SimplyProductShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimplyProductShop.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<ProductModel, ProductViewModel>();
            Mapper.CreateMap<ProductViewModel, ProductModel>();
        }
    }
}