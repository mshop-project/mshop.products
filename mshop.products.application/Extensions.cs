using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using mshop.products.application.Mapper.Categories;
using mshop.products.application.Mapper.Products;

namespace mshop.products.application
{
    public static class Extensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            var assembly = typeof(Extensions).Assembly;
            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssemblies(assembly);
            });

            services.AddScoped(provider => new MapperConfiguration(cfg =>
            {
                var scope = provider.CreateScope();
                cfg.AddProfile(new CategoryProfile());
                cfg.AddProfile(new ProductProfile());
            }).CreateMapper()

            );
        }
    }
}
