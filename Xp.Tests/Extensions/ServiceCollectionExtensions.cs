using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xp.Infra.Contexts;
using Xp.Infra.Repositories;
using Xp.Services.Service;
using Xp.Tests.Main;
using Xp.Tests.Repositories;
using Xp.Tests.Services;

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

            //Services
            services.AddScoped<ClienteService>();    

            //Tests
            services.AddScoped<RepositoryTest>();
            services.AddScoped<ServiceTest>();
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
