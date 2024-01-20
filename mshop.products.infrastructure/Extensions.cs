using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using mshop.products.domain.Repositories.Categories;
using mshop.products.domain.Repositories.Products;
using mshop.products.infrastructure.Persistence;
using mshop.products.infrastructure.Repositories.Categories;
using mshop.products.infrastructure.Repositories.Products;

namespace mshop.products.infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            return services
                .AddDbContext<ProductsDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("ProductsDatabase")))
                .AddScoped<ICategoriesRepository, CategoriesRepository>()
                .AddScoped<IProductsRepository, ProductsRepository>();
        }
    }
}
