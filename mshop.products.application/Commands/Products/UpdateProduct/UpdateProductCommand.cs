using MediatR;
using mshop.products.application.DTOs.Products;

namespace mshop.products.application.Commands.Products.UpdateProduct
{
    public record UpdateProductCommand(Guid productId, UpdateProductDto UpdateProductDto) : IRequest;
}
