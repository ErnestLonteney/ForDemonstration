using AutoMapper;
using ServiceOrientedArchetecture.Models;
using Services.Models;

namespace ServiceOrientedArchetecture.Configuration
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            CreateMap<ProductModel, ProductModelView>().ReverseMap();
            CreateMap<BrandModel, BrandModelView>().ReverseMap();
        }
    }
}
