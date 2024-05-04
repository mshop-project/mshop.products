using mshop.sharedkernel.coredata.Products;

namespace mshop.products.domain.Repositories.Categories
{
    public interface ICategoriesRepository
    {
        public Task CreateAsync(Category category);
        public Task<IEnumerable<Category>> GetAllAsync();
    }
}
