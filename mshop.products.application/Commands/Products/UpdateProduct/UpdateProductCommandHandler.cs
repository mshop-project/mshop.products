using AutoMapper;
using MediatR;
using mshop.products.domain.Repositories.Products;
using mshop.sharedkernel.coredata.Products;
namespace mshop.products.application.Commands.Products.UpdateProduct
{
    internal class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IProductsRepository productsRepository, IMapper mapper)
        {
            _productsRepository = productsRepository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _productsRepository.GetByIdAsync(request.productId);
           
            product.Name = request.UpdateProductDto.Name ?? product.Name;
            product.Price = request.UpdateProductDto.Price ?? product.Price;
            product.Description = request.UpdateProductDto.Description ?? product.Description;
            product.CategoryId = request.UpdateProductDto.CategoryId ?? product.CategoryId;
            product.ImageUrl = request.UpdateProductDto.ImageUrl ?? product.ImageUrl;

            await _productsRepository.UpdateAsync(product);
        }
    }
}
