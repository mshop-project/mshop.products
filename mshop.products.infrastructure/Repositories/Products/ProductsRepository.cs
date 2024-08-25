using Microsoft.EntityFrameworkCore;
using mshop.products.domain.Repositories.Products;
using mshop.products.infrastructure.Persistence;
using mshop.sharedkernel.coredata.Products;

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

        public async Task DeleteAsync(Guid productId)
        {
            var product = await _productsDbContext.Products.FirstOrDefaultAsync(p => p.Id == productId);
            if (product is null)
            {
                return;
            }
            _productsDbContext.Products.Remove(product);
            await _productsDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            _productsDbContext.Products.Update(product);
            await _productsDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _productsDbContext.Products.Include(p => p.Category).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetByIdsAsync(IEnumerable<Guid> ids)
        {
            return await _productsDbContext.Products.Where(product => ids.Contains(product.Id)).Include(p => p.Category).ToListAsync();
        }

        public async Task<Product> GetByIdAsync(Guid productId)
        {
            var product = await _productsDbContext.Products.FirstOrDefaultAsync(p => p.Id == productId);
            if (product is null)
            {
                throw new ArgumentException("Given product id does not exist");
            }

            return product;
        }
    }
}
