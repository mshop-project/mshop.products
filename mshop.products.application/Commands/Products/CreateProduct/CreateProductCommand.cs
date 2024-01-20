using MediatR;
using mshop.products.application.DTOs.Categories;
using mshop.products.application.DTOs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mshop.products.application.Commands.Products.CreateProduct
{
    public sealed record CreateProductCommand(CreateProductDto ProductDto) : IRequest;
}
