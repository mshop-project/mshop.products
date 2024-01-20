using mshop.products.domain.Entities;

namespace mshop.products.domain.Repositories.Products
{
    public interface IProductsRepository
    {
        public Task CreateAsync(Product product);
        public Task<IEnumerable<Product>> GetAllAsync();    
    }
}
