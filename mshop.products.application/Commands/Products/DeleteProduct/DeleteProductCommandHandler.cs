using AutoMapper;
using MediatR;
using mshop.products.application.Commands.Products.CreateProduct;
using mshop.products.domain.Repositories.Products;
using mshop.sharedkernel.coredata.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mshop.products.application.Commands.Products.DeleteProduct
{
    internal class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;

        public DeleteProductCommandHandler(IProductsRepository productsRepository, IMapper mapper)
        {
            _productsRepository = productsRepository;
            _mapper = mapper;
        }

        public async Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            await _productsRepository.DeleteAsync(request.ProductId);
        }
    }
}
