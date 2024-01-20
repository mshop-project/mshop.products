using System.ComponentModel.DataAnnotations;

namespace mshop.products.application.DTOs.Categories
{
    public class CreateCategoryDto
    {
        [Required]
        public string Name { get; set; } = null!;
    }
}
