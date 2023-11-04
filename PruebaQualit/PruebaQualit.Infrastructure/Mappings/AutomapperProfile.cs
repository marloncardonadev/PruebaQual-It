using AutoMapper;
using PruebaQualit.Core.DTOs;
using PruebaQualit.Core.Entities;

namespace PruebaQualit.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();

        }
    }
}
