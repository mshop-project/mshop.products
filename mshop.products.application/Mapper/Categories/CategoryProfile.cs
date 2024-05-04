using AutoMapper;
using mshop.products.application.DTOs.Categories;
using mshop.sharedkernel.coredata.Products;

namespace mshop.products.application.Mapper.Categories
{
    public class CategoryProfile: Profile
    {
        public CategoryProfile()
        { 
            CreateMap <CreateCategoryDto, Category>();
            CreateMap <Category, CreateCategoryDto>();
            CreateMap <Category, ReadCategoryDto>();
            CreateMap <ReadCategoryDto, Category>();
        }
    }
}
