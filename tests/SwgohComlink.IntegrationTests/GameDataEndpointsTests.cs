using System.Net;
using System.Net.Http.Json;
using FluentAssertions;
using SwgohComlink.Client.Models.GameData;
using SwgohComlink.Client.Requests;

namespace SwgohComlink.IntegrationTests;

public class GameDataEndpointsTests(MockApiWebApplicationFactory factory) : IClassFixture<MockApiWebApplicationFactory>
{
    private readonly HttpClient _client = factory.CreateClient();

    [Fact]
    public async Task GetEnums_ReturnsEnumsData()
    {
        // Act
        var response = await _client.GetAsync("/enums");

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var enumsResponse = await response.Content.ReadFromJsonAsync<GetEnumsResponse>();
        enumsResponse.Should().NotBeNull();
        enumsResponse.Enums.Should().NotBeEmpty();
    }

    [Fact]
    public async Task GetGameData_ReturnsGameData()
    {
        // Arrange
        var request = new GetGameDataRequest
        {
            Payload = new GetGameDataRequestPayload()
        };

        // Act
        var response = await _client.PostAsJsonAsync("/data", request);

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var gameDataResponse = await response.Content.ReadFromJsonAsync<GetGameDataResponse>();
        gameDataResponse.Should().NotBeNull();
        gameDataResponse.Units.Should().NotBeEmpty();
        gameDataResponse.Category.Should().NotBeEmpty();
    }

    [Fact]
    public async Task GetMetadata_ReturnsMetadata()
    {
        // Arrange
        var request = new GetMetaDataRequest
        {
            Payload = new GetMetaDataRequestPayload()
        };

        // Act
        var response = await _client.PostAsJsonAsync("/metadata", request);

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var metadataResponse = await response.Content.ReadFromJsonAsync<GetMetaDataResponse>();
        metadataResponse.Should().NotBeNull();
        metadataResponse.LatestGamedataVersion.Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task GetLocalization_ReturnsLocalizationBundle()
    {
        // Arrange
        var request = new GetLocalizationBundleRequest
        {
            Payload = new GetLocalizationBundleRequestPayload()
        };

        // Act
        var response = await _client.PostAsJsonAsync("/localization", request);

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var localizationResponse = await response.Content.ReadFromJsonAsync<GetLocalizationBundleResponse>();
        localizationResponse.Should().NotBeNull();
        localizationResponse.LocalizationBundle.Should().NotBeNullOrEmpty();
    }
}