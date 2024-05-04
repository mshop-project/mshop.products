using AutoMapper;
using mshop.products.application.DTOs.Products;
using mshop.sharedkernel.coredata.Products;

namespace mshop.products.application.Mapper.Products
{
    public class ProductProfile : Profile
    {
        public ProductProfile() 
        {
            CreateMap<CreateProductDto, Product>();
            CreateMap<Product, ReadProductDto>()
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category));
            CreateMap<ReadProductDto, Product>()
                    .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category));
        } 
    }
}
