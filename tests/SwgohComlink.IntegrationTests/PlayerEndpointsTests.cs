using System.Net;
using System.Net.Http.Json;
using FluentAssertions;
using SwgohComlink.Client.Models.Player;
using SwgohComlink.Client.Requests;
using SwgohComlink.MockApi.SampleData;

namespace SwgohComlink.IntegrationTests;

public class PlayerEndpointsTests(MockApiWebApplicationFactory factory) : IClassFixture<MockApiWebApplicationFactory>
{
    private readonly HttpClient _client = factory.CreateClient();

    [Fact]
    public async Task GetPlayer_WithValidPlayerId_ReturnsPlayerData()
    {
        // Arrange
        var request = new GetPlayerRequest
        {
            Payload = new GetPlayerRequestPayload
            {
                PlayerId = MockTestIds.TestPlayerId1
            }
        };

        // Act
        var response = await _client.PostAsJsonAsync("/player", request);

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var playerResponse = await response.Content.ReadFromJsonAsync<GetPlayerResponse>();
        playerResponse.Should().NotBeNull();
        playerResponse.PlayerId.Should().Be(MockTestIds.TestPlayerId1);
        playerResponse.Name.Should().Be("Test Player One");
        playerResponse.Level.Should().Be(85);
    }

    [Fact]
    public async Task GetPlayer_WithValidAllyCode_ReturnsPlayerData()
    {
        // Arrange
        var request = new GetPlayerRequest
        {
            Payload = new GetPlayerRequestPayload
            {
                AllyCode = MockTestIds.TestAllyCode1
            }
        };

        // Act
        var response = await _client.PostAsJsonAsync("/player", request);

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var playerResponse = await response.Content.ReadFromJsonAsync<GetPlayerResponse>();
        playerResponse.Should().NotBeNull();
        playerResponse.AllyCode.Should().Be(123456789);
    }

    [Fact]
    public async Task GetPlayer_WithNoIdentifier_ReturnsNotFound()
    {
        // Arrange
        var request = new GetPlayerRequest
        {
            Payload = new GetPlayerRequestPayload()
        };

        // Act
        var response = await _client.PostAsJsonAsync("/player", request);

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task GetPlayerArenaProfile_WithValidPlayerId_ReturnsArenaProfile()
    {
        // Arrange
        var request = new GetPlayerArenaProfileRequest
        {
            Payload = new GetPlayerRequestPayload
            {
                PlayerId = MockTestIds.TestPlayerId1
            }
        };

        // Act
        var response = await _client.PostAsJsonAsync("/playerArena", request);

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var arenaResponse = await response.Content.ReadFromJsonAsync<GetPlayerArenaProfileResponse>();
        arenaResponse.Should().NotBeNull();
        arenaResponse.PlayerId.Should().Be(MockTestIds.TestPlayerId1);
        arenaResponse.PvpProfile.Should().NotBeEmpty();
    }
}