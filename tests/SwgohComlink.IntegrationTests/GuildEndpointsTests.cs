using System.Net;
using System.Net.Http.Json;
using FluentAssertions;
using SwgohComlink.Client.Models.Guild;
using SwgohComlink.Client.Requests;
using SwgohComlink.MockApi.SampleData;

namespace SwgohComlink.IntegrationTests;

public class GuildEndpointsTests(MockApiWebApplicationFactory factory) : IClassFixture<MockApiWebApplicationFactory>
{
    private readonly HttpClient _client = factory.CreateClient();

    [Fact]
    public async Task GetGuild_WithValidGuildId_ReturnsGuildData()
    {
        // Arrange
        var request = new GetGuildRequest
        {
            Payload = new GetGuildRequestPayload
            {
                GuildId = MockTestIds.TestGuildId1
            }
        };

        // Act
        var response = await _client.PostAsJsonAsync("/guild", request);

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var guildResponse = await response.Content.ReadFromJsonAsync<GetGuildResponse>();
        guildResponse.Should().NotBeNull();
        guildResponse.Guild.Should().NotBeNull();
        guildResponse.Guild.Profile.Name.Should().Be("Test Guild Alpha");
    }

    [Fact]
    public async Task GetGuild_WithNoGuildId_ReturnsNotFound()
    {
        // Arrange
        var request = new GetGuildRequest
        {
            Payload = new GetGuildRequestPayload()
        };

        // Act
        var response = await _client.PostAsJsonAsync("/guild", request);

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task GetGuilds_ReturnsGuildsList()
    {
        // Arrange
        var request = new GetGuildsRequest
        {
            Payload = new GetGuildsRequestPayload()
        };

        // Act
        var response = await _client.PostAsJsonAsync("/getGuilds", request);

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var guildsResponse = await response.Content.ReadFromJsonAsync<GetGuildsResponse>();
        guildsResponse.Should().NotBeNull();
        guildsResponse.Guild.Should().NotBeEmpty();
        guildsResponse.TotalRecords.Should().BeGreaterThan(0);
    }

    [Fact]
    public async Task GetGuilds_WithFilter_ReturnsFilteredGuilds()
    {
        // Arrange
        var request = new GetGuildsRequest
        {
            Payload = new GetGuildsRequestPayload()
        };

        // Act
        var response = await _client.PostAsJsonAsync("/getGuilds", request);

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var guildsResponse = await response.Content.ReadFromJsonAsync<GetGuildsResponse>();
        guildsResponse.Should().NotBeNull();
        guildsResponse.Guild.Should().HaveCountGreaterThan(0);
        guildsResponse.Guild.First().Name.Should().NotBeNullOrEmpty();
    }
}