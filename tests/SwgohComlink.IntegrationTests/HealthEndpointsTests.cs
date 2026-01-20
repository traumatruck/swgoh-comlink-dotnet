using System.Net;
using FluentAssertions;

namespace SwgohComlink.IntegrationTests;

public class HealthEndpointsTests(MockApiWebApplicationFactory factory) : IClassFixture<MockApiWebApplicationFactory>
{
    private readonly HttpClient _client = factory.CreateClient();

    [Fact]
    public async Task GetReadyz_ReturnsOk()
    {
        // Act
        var response = await _client.GetAsync("/readyz");

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]
    public async Task GetLivez_ReturnsOk()
    {
        // Act
        var response = await _client.GetAsync("/livez");

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]
    public async Task GetMetrics_ReturnsPrometheusMetrics()
    {
        // Act
        var response = await _client.GetAsync("/metrics");

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }
}
