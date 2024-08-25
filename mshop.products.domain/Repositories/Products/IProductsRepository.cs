using mshop.sharedkernel.coredata.Products;

namespace mshop.products.domain.Repositories.Products
{
    public interface IProductsRepository
    {
        public Task CreateAsync(Product product);
        public Task DeleteAsync(Guid productId);
        public Task UpdateAsync(Product product);
        public Task<IEnumerable<Product>> GetAllAsync();
        public Task<Product> GetByIdAsync(Guid productId);
        public Task<IEnumerable<Product>> GetByIdsAsync(IEnumerable<Guid> ids);
    }
}
