using mshop.products.application.DTOs.Categories;

namespace mshop.products.application.DTOs.Products
{
    internal class ReadProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public decimal Price { get; set; }
        public ReadCategoryDto Category { get; set; } = null!;
    }
}
