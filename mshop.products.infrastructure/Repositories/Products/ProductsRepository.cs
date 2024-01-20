using mshop.products.domain.Entities;
using mshop.products.domain.Repositories.Products;
using mshop.products.infrastructure.Persistence;

namespace mshop.products.infrastructure.Repositories.Products
{
    internal class ProductsRepository : IProductsRepository
    {
        private readonly ProductsDbContext _productsDbContext;

        public ProductsRepository(ProductsDbContext productsDbContext)
        {
            _productsDbContext = productsDbContext;
        }

        public async Task CreateAsync(Product product)
        {
            await _productsDbContext.Products.AddAsync(product);
            await _productsDbContext.SaveChangesAsync();
        }
    }
}
