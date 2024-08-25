using MediatR;

namespace mshop.products.application.Commands.Products.DeleteProduct
{
    public record DeleteProductCommand(Guid ProductId) : IRequest;
}
