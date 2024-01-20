using AutoMapper;
using mshop.products.application.DTOs.Products;
using mshop.products.domain.Entities;

namespace mshop.products.application.Mapper.Products
{
    public class ProductProfile : Profile
    {
        public ProductProfile() 
        {
            CreateMap<CreateProductDto, Product>();
            CreateMap<Product, ReadProductDto>()
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category));
        } 
    }
}
