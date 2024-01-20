using MediatR;
using mshop.products.application.DTOs.Categories;

namespace mshop.products.application.Commands.Categories.CreateCategory
{
    public sealed record CreateCategoryCommand(CreateCategoryDto CategoryDto) : IRequest;
}
