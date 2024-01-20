using mshop.products.domain.Entities;
using mshop.products.domain.Repositories.Categories;
using mshop.products.infrastructure.Persistence;

namespace mshop.products.infrastructure.Repositories.Categories
{
    public sealed class CategoriesRepository : ICategoriesRepository
    {
        private readonly ProductsDbContext _productsDbContext;

        public CategoriesRepository(ProductsDbContext productsDbContext)
        {
            _productsDbContext = productsDbContext;
        }

        public async Task CreateAsync(Category category)
        {
            await _productsDbContext.Categories.AddAsync(category);
            await _productsDbContext.SaveChangesAsync();
        }
            
    }
}
