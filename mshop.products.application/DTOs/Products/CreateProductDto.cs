namespace mshop.products.application.DTOs.Products
{
    public class CreateProductDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }
    }
}
