using mshop.products.application;
using mshop.products.infrastructure;

namespace mshop.products.api
{
    public static class Extensions
    {
        public static IServiceCollection AddProductsExtensions(this IServiceCollection services, IConfiguration configuration)
        {
            return services
                .AddInfrastructure(configuration)
                .AddApplication(); 
        }
    }
}