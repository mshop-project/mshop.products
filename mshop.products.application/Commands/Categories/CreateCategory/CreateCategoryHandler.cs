using AutoMapper;
using MediatR;
using mshop.products.domain.Entities;
using mshop.products.domain.Repositories.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mshop.products.application.Commands.Categories.CreateCategory
{
    internal sealed class CreateCategoryHandler : IRequestHandler<CreateCategoryCommand>
    {
        private readonly ICategoriesRepository _categoriesRepository;
        private readonly IMapper _mapper;

        public CreateCategoryHandler(ICategoriesRepository categoriesRepository, IMapper mapper)
        {
            _categoriesRepository = categoriesRepository;
            _mapper = mapper;
        }

        public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Category>(request.CategoryDto);

            await _categoriesRepository.CreateAsync(category);
        }
    }
}
