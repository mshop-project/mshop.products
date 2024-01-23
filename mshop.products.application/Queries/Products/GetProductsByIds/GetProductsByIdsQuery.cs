using MediatR;
using mshop.products.application.DTOs.Products;

namespace mshop.products.application.Queries.Products.GetProductsByIds
{
    public sealed record GetProductsByIdsQuery(IEnumerable<Guid> Ids) : IRequest<IEnumerable<ReadProductDto>>;
}
