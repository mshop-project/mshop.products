using Microsoft.Extensions.DependencyInjection;

namespace mshop.products.infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }
    }
}
