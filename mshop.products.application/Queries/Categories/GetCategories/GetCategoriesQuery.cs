using MediatR;
using mshop.products.application.DTOs.Categories;

namespace mshop.products.application.Queries.Categories.GetCategories
{
    public sealed record GetCategoriesQuery() : IRequest<IEnumerable<ReadCategoryDto>>;
}
