using MediatR;
using mshop.products.application.DTOs.Products;

namespace mshop.products.application.Queries.Products
{
    public sealed record GetProductsQuery() : IRequest<IEnumerable<ReadProductDto>>;
}
