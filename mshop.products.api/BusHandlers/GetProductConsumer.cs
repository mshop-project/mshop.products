using AutoMapper;
using MassTransit;
using MediatR;
using mshop.products.application.Queries.Products.GetProductsByIds;
using mshop.sharedkernel.coredata.Products;
using mshop.sharedkernel.messaging.Data.Request.Products;
using mshop.sharedkernel.messaging.Data.Response.Products;

namespace mshop.products.api.BusHandlers
{
    public class GetProductConsumer(IMediator _mediator, IMapper mapper) : IConsumer<GetProductsByIdsRequest>
    {
        public async Task Consume(ConsumeContext<GetProductsByIdsRequest> context)
        {
            var products = new ProductsResponse();

            var result = await _mediator.Send(new GetProductsByIdsQuery(context.Message.ids));

            products.Products.AddRange(mapper.Map<IEnumerable<Product>>(result));

            await context.RespondAsync(products);
        }
    }
}