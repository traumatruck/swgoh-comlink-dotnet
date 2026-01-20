using System.Net;
using System.Net.Http.Json;
using FluentAssertions;
using SwgohComlink.Client.Models.Events;
using SwgohComlink.Client.Requests;

namespace SwgohComlink.IntegrationTests;

public class EventEndpointsTests(MockApiWebApplicationFactory factory) : IClassFixture<MockApiWebApplicationFactory>
{
    private readonly HttpClient _client = factory.CreateClient();

    [Fact]
    public async Task GetEvents_ReturnsEventsList()
    {
        // Arrange
        var request = new GetEventsRequest();

        // Act
        var response = await _client.PostAsJsonAsync("/getEvents", request);

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var eventsResponse = await response.Content.ReadFromJsonAsync<GetEventsResponse>();
        eventsResponse.Should().NotBeNull();
        eventsResponse.GameEvent.Should().NotBeEmpty();
    }

    [Fact]
    public async Task GetEvents_ReturnsEventsWithInstances()
    {
        // Arrange
        var request = new GetEventsRequest();

        // Act
        var response = await _client.PostAsJsonAsync("/getEvents", request);

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var eventsResponse = await response.Content.ReadFromJsonAsync<GetEventsResponse>();
        eventsResponse.Should().NotBeNull();
        eventsResponse.GameEvent.Should().Contain(e => e.Instance.Count > 0);
    }
}