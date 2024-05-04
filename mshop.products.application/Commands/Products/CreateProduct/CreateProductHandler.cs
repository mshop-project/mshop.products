using AutoMapper;
using MediatR;
using mshop.products.domain.Repositories.Products;
using mshop.sharedkernel.coredata.Products;

namespace mshop.products.application.Commands.Products.CreateProduct
{
    internal class CreateProductHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;

        public CreateProductHandler(IProductsRepository productsRepository, IMapper mapper)
        {
            _productsRepository = productsRepository;
            _mapper = mapper;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request.ProductDto);

            await _productsRepository.CreateAsync(product);
        }
    }
}
