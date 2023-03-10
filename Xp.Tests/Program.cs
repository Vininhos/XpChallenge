using Microsoft.Extensions.DependencyInjection;
using Xp.Tests.Extensions;
using Xp.Tests.Main;

public class Program
{
    private static void Main(string[] args)
    {
        try
        {
            var service = ConfigureServices();
            IServiceProvider serviceProvider = service.BuildServiceProvider();
            var eventService = serviceProvider.GetRequiredService<AppTestMain>();
            eventService.Execute();

        }catch(Exception ex)
        {
            throw;
        }
    }
    static IServiceCollection ConfigureServices()
    {
        IServiceCollection services = new ServiceCollection();
        services.AddDependencies();
        return services;
    }
}