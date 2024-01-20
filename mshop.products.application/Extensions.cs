using Microsoft.Extensions.DependencyInjection;

namespace mshop.products.application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }
    }
}
