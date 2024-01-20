using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using mshop.products.infrastructure.Persistence;

namespace mshop.products.infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddDbContext<ProductsDbContext>(options => options.UseNpgsql(
                configuration.GetConnectionString("ProductsDatabase")));
        }
    }
}
