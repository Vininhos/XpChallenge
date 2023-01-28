using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xp.Infra.Repositories;

namespace Xp.Tests.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            IConfiguration configuration = GetConfiguration();
            services.AddSingleton(configuration);
            RegisterDependencies(services);

            return services;
        }

        private static void RegisterDependencies(IServiceCollection services)
        {
            services.AddScoped<AppTestMain>();

            //Repository
            services.AddScoped<IClienteRepository, ClienteRepository>();

            //Tests
            services.AddScoped<DomainTests>();
        }

        private static IConfiguration GetConfiguration()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json")
                .AddEnvironmentVariables();

             IConfiguration configuration = builder.Build();

            return configuration;
        }
    }
}
