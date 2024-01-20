using AutoMapper;
using mshop.products.application.DTOs.Categories;
using mshop.products.application.DTOs.Products;
using mshop.products.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mshop.products.application.Mapper.Products
{
    public class ProductProfile : Profile
    {
        public ProductProfile() 
        {
            CreateMap<CreateProductDto, Product>();
        } 
    }
}
