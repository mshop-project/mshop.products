using MassTransit;
using mshop.products.api.BusHandlers;
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

        public static IBusRegistrationConfigurator AddProductsBusConfig(this IBusRegistrationConfigurator config)
        {
            config.AddConsumer<GetProductConsumer>();
            return config;
        }
    }
}