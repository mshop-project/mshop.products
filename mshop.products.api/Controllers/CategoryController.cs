﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using mshop.products.application.Commands.Categories.CreateCategory;
using mshop.products.application.DTOs.Categories;

namespace mshop.products.api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryDto categoryDto)
        {
            await _mediator.Send(new CreateCategoryCommand(categoryDto));
            return Ok();
        }
    }
}
