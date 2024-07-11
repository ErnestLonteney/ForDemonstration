using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Entities;
using Services.Models;

namespace Services.Configuration
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            CreateMap<BrandModel, Brand>().ReverseMap();
            CreateMap<Product, ProductModel>().ReverseMap();     
        }
    }
}
