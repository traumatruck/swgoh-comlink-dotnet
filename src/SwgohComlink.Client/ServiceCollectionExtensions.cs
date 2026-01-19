using Microsoft.Extensions.DependencyInjection;

namespace SwgohComlink.Client;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSwgohComlink(this IServiceCollection serviceCollection, string baseUrl)
    {
        serviceCollection.AddHttpClient<ISwgohComlinkClient, SwgohComlinkClient>(client =>
        {
            client.BaseAddress = new Uri(baseUrl);
        });

        return serviceCollection;
    }
}