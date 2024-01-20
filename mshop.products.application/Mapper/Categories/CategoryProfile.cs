using AutoMapper;
using mshop.products.application.DTOs.Categories;
using mshop.products.domain.Entities;

namespace mshop.products.application.Mapper.Categories
{
    public class CategoryProfile: Profile
    {
        public CategoryProfile()
        { 
            CreateMap <CreateCategoryDto, Category>();
        }
    }
}
