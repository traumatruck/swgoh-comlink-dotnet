using System.Net;
using System.Text.Json;
using FluentAssertions;
using SwgohComlink.Client.Models.Metrics;

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
    public async Task GetMetrics_ReturnsOk()
    {
        // Act
        var response = await _client.GetAsync("/metrics");

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]
    public async Task GetMetrics_ReturnsPlainSuccessResponseWithPrometheusMetrics()
    {
        // Act
        var response = await _client.GetAsync("/metrics");
        var content = await response.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<PlainSuccessResponse>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        result.Should().NotBeNull();
        result!.Value.Should().NotBeNullOrEmpty();
        result.Value.Should().Contain("# HELP");
        result.Value.Should().Contain("# TYPE");
    }

    [Fact]
    public async Task GetMetrics_ReturnsValidPrometheusFormat()
    {
        // Act
        var response = await _client.GetAsync("/metrics");
        var content = await response.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<PlainSuccessResponse>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        // Assert
        result.Should().NotBeNull();
        result!.Value.Should().NotBeNull();
        
        // Verify Prometheus metric format
        var lines = result.Value!.Split('\n', StringSplitOptions.RemoveEmptyEntries);
        lines.Should().Contain(line => line.StartsWith("# HELP"));
        lines.Should().Contain(line => line.StartsWith("# TYPE"));
        lines.Should().Contain(line => line.Contains("swgoh_comlink_requests_total"));
    }
}
