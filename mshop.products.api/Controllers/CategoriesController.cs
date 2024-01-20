using MediatR;
using Microsoft.AspNetCore.Mvc;
using mshop.products.application.Commands.Categories.CreateCategory;
using mshop.products.application.DTOs.Categories;
using mshop.products.application.Queries.Categories.GetCategories;

namespace mshop.products.api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryDto categoryDto)
        {
            await _mediator.Send(new CreateCategoryCommand(categoryDto));
            return Ok();
        }

        [HttpGet("")]
        public async Task<IActionResult> GetCategories()
        {
            var result = await _mediator.Send(new GetCategoriesQuery());
            return Ok(result);
        }
    }
}
