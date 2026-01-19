using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;

namespace SwgohComlink.Client.Tests;

public class ServiceCollectionExtensionsTests
{
    [Fact]
    public void AddSwgohComlink_RegistersClientWithCorrectBaseUrl()
    {
        // Arrange
        var services = new ServiceCollection();
        const string baseUrl = "http://localhost:3000";

        // Act
        services.AddSwgohComlink(baseUrl);
        var serviceProvider = services.BuildServiceProvider();
        var httpClientFactory = serviceProvider.GetRequiredService<IHttpClientFactory>();
        var client = httpClientFactory.CreateClient(nameof(ISwgohComlinkClient));

        // Assert
        client.BaseAddress.Should().Be(new Uri(baseUrl));
    }

    [Fact]
    public void AddSwgohComlink_RegistersISwgohComlinkClient()
    {
        // Arrange
        var services = new ServiceCollection();
        const string baseUrl = "http://localhost:3000";

        // Act
        services.AddSwgohComlink(baseUrl);
        var serviceProvider = services.BuildServiceProvider();
        var client = serviceProvider.GetService<ISwgohComlinkClient>();

        // Assert
        client.Should().NotBeNull();
        client.Should().BeOfType<SwgohComlinkClient>();
    }

    [Fact]
    public void AddSwgohComlink_ReturnsSameServiceCollection()
    {
        // Arrange
        var services = new ServiceCollection();
        const string baseUrl = "http://localhost:3000";

        // Act
        var result = services.AddSwgohComlink(baseUrl);

        // Assert
        result.Should().BeSameAs(services);
    }
}
