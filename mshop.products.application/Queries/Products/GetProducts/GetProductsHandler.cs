using AutoMapper;
using MediatR;
using mshop.products.application.DTOs.Products;
using mshop.products.domain.Repositories.Products;

namespace mshop.products.application.Queries.Products.GetProducts
{
    internal class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<ReadProductDto>>
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;

        public GetProductsHandler(IProductsRepository productsRepository, IMapper mapper)
        {
            _productsRepository = productsRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ReadProductDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productsRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<ReadProductDto>>(products);
        }
    }
}
