using MediatR;
using Microsoft.AspNetCore.Mvc;
using mshop.products.application.Commands.Products.CreateProduct;
using mshop.products.application.DTOs.Products;
using mshop.products.application.Queries.Categories.GetCategories;
using mshop.products.application.Queries.Products;

namespace mshop.products.api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductDto productDto)
        {
            await _mediator.Send(new CreateProductCommand(productDto));
            return Ok();
        }

        [HttpGet("")]
        public async Task<IActionResult> GetProducts()
        {
            var result = await _mediator.Send(new GetProductsQuery());
            return Ok(result);
        }
    }
}
