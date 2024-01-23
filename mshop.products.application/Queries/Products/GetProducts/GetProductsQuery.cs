using MediatR;
using mshop.products.application.DTOs.Products;

namespace mshop.products.application.Queries.Products.GetProducts
{
    public sealed record GetProductsQuery() : IRequest<IEnumerable<ReadProductDto>>;
}
