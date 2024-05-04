using mshop.sharedkernel.coredata.Products;

namespace mshop.products.domain.Repositories.Products
{
    public interface IProductsRepository
    {
        public Task CreateAsync(Product product);
        public Task<IEnumerable<Product>> GetAllAsync();
        public Task<IEnumerable<Product>> GetByIdsAsync(IEnumerable<Guid> ids);
    }
}
