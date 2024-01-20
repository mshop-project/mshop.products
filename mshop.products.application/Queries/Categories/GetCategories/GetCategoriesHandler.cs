using AutoMapper;
using MediatR;
using mshop.products.application.DTOs.Categories;
using mshop.products.domain.Repositories.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mshop.products.application.Queries.Categories.GetCategories
{
    internal class GetCategoriesHandler : IRequestHandler<GetCategoriesQuery, IEnumerable<ReadCategoryDto>>
    {
        private readonly ICategoriesRepository _categoriesRepository;
        private readonly IMapper _mapper;

        public GetCategoriesHandler(ICategoriesRepository categoriesRepository, IMapper mapper)
        {
            _categoriesRepository = categoriesRepository;   
            _mapper = mapper;
        }

        public async Task<IEnumerable<ReadCategoryDto>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = await _categoriesRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<ReadCategoryDto>>(categories);
        }
    }
}
