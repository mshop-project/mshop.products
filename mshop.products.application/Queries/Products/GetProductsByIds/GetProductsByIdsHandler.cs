using AutoMapper;
using MediatR;
using mshop.products.application.DTOs.Products;
using mshop.products.domain.Repositories.Products;

namespace mshop.products.application.Queries.Products.GetProductsByIds
{
    internal class GetProductsByIdsHandler : IRequestHandler<GetProductsByIdsQuery, IEnumerable<ReadProductDto>>
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;

        public GetProductsByIdsHandler(IProductsRepository productsRepository, IMapper mapper)
        {
            _productsRepository = productsRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ReadProductDto>> Handle(GetProductsByIdsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productsRepository.GetByIdsAsync(request.Ids);

            return _mapper.Map<IEnumerable<ReadProductDto>>(products);
        }
    }
}
