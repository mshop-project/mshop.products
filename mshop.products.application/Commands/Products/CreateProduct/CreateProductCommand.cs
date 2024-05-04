using MediatR;
using mshop.products.application.DTOs.Products;

namespace mshop.products.application.Commands.Products.CreateProduct
{
    public sealed record CreateProductCommand(CreateProductDto ProductDto) : IRequest;
}
