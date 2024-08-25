using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mshop.products.application.DTOs.Products
{
    public class UpdateProductDto()
    {
        public string? Name { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public string? ImageUrl { get; set; } = null!;
        public decimal? Price { get; set; }
        public Guid? CategoryId { get; set; }
    }
}
