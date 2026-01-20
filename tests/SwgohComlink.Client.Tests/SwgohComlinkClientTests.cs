using System.Net;
using System.Text.Json;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using RichardSzalay.MockHttp;
using SwgohComlink.Client.Models.GameData;
using SwgohComlink.Client.Models.Player;
using SwgohComlink.Client.Requests;

namespace SwgohComlink.Client.Tests;

public class SwgohComlinkClientTests
{
    private readonly SwgohComlinkClient _client;
    private readonly MockHttpMessageHandler _mockHttp;
    private readonly Mock<ILogger<SwgohComlinkClient>> _loggerMock;

    public SwgohComlinkClientTests()
    {
        _mockHttp = new MockHttpMessageHandler();
        var httpClient = _mockHttp.ToHttpClient();
        httpClient.BaseAddress = new Uri("http://localhost:3000");
        _loggerMock = new Mock<ILogger<SwgohComlinkClient>>();
        _client = new SwgohComlinkClient(httpClient, _loggerMock.Object);
    }

    [Fact]
    public async Task SendRequestAsync_GetRequest_SendsGetRequest()
    {
        // Arrange
        var expectedResponse = new GetEnumsResponse
        {
            Enums = new Dictionary<string, object>
            {
                { "TestEnum", "TestValue" }
            }
        };

        _mockHttp.When(HttpMethod.Get, "http://localhost:3000/enums")
            .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        var request = new GetEnumsRequest();

        // Act
        var result = await _client.SendRequestAsync<GetEnumsRequest, GetEnumsResponse>(request);

        // Assert
        result.Should().NotBeNull();
        result.Enums.Should().ContainKey("TestEnum");
    }

    [Fact]
    public async Task SendRequestAsync_PostRequest_SendsPostRequestWithBody()
    {
        // Arrange
        var expectedResponse = new GetPlayerResponse
        {
            Name = "TestPlayer",
            Level = 85,
            AllyCode = 123456789,
            PlayerId = "player-id-123"
        };

        _mockHttp.When(HttpMethod.Post, "http://localhost:3000/player")
            .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        var request = new GetPlayerRequest
        {
            Payload = new GetPlayerRequestPayload
            {
                AllyCode = "123456789"
            }
        };

        // Act
        var result = await _client.SendRequestAsync<GetPlayerRequest, GetPlayerResponse>(request);

        // Assert
        result.Should().NotBeNull();
        result.Name.Should().Be("TestPlayer");
        result.Level.Should().Be(85);
        result.AllyCode.Should().Be(123456789);
        result.PlayerId.Should().Be("player-id-123");
    }

    [Fact]
    public async Task SendRequestAsync_PostRequest_WithPlayerId_SendsCorrectPayload()
    {
        // Arrange
        var expectedResponse = new GetPlayerResponse
        {
            Name = "TestPlayer",
            PlayerId = "player-id-456"
        };

        _mockHttp.When(HttpMethod.Post, "http://localhost:3000/player")
            .WithPartialContent("player-id-456")
            .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        var request = new GetPlayerRequest
        {
            Payload = new GetPlayerRequestPayload
            {
                PlayerId = "player-id-456"
            }
        };

        // Act
        var result = await _client.SendRequestAsync<GetPlayerRequest, GetPlayerResponse>(request);

        // Assert
        result.Should().NotBeNull();
        result.PlayerId.Should().Be("player-id-456");
    }

    [Fact]
    public async Task SendRequestAsync_HttpError_ThrowsHttpRequestException()
    {
        // Arrange
        _mockHttp.When(HttpMethod.Get, "http://localhost:3000/enums")
            .Respond(HttpStatusCode.InternalServerError);

        var request = new GetEnumsRequest();

        // Act
        var act = async () => await _client.SendRequestAsync<GetEnumsRequest, GetEnumsResponse>(request);

        // Assert
        await act.Should().ThrowAsync<HttpRequestException>();
    }

    [Fact]
    public async Task SendRequestAsync_NotFoundResponse_ThrowsHttpRequestException()
    {
        // Arrange
        _mockHttp.When(HttpMethod.Post, "http://localhost:3000/player")
            .Respond(HttpStatusCode.NotFound);

        var request = new GetPlayerRequest
        {
            Payload = new GetPlayerRequestPayload
            {
                AllyCode = "999999999"
            }
        };

        // Act
        var act = async () => await _client.SendRequestAsync<GetPlayerRequest, GetPlayerResponse>(request);

        // Assert
        await act.Should().ThrowAsync<HttpRequestException>();
    }

    [Fact]
    public async Task SendRequestAsync_NullResponse_ThrowsInvalidOperationException()
    {
        // Arrange
        _mockHttp.When(HttpMethod.Get, "http://localhost:3000/enums")
            .Respond("application/json", "null");

        var request = new GetEnumsRequest();

        // Act
        var act = async () => await _client.SendRequestAsync<GetEnumsRequest, GetEnumsResponse>(request);

        // Assert
        await act.Should().ThrowAsync<InvalidOperationException>()
            .WithMessage("Response deserialization returned null for endpoint: /enums*");
    }

    [Fact]
    public async Task SendRequestAsync_CancellationRequested_ThrowsOperationCanceledException()
    {
        // Arrange
        _mockHttp.When(HttpMethod.Get, "http://localhost:3000/enums")
            .Respond(async () =>
            {
                await Task.Delay(5000);
                return new HttpResponseMessage(HttpStatusCode.OK);
            });

        var request = new GetEnumsRequest();
        var cts = new CancellationTokenSource();
        cts.Cancel();

        // Act
        var act = async () => 
            await _client.SendRequestAsync<GetEnumsRequest, GetEnumsResponse>(request, cts.Token);

        // Assert
        await act.Should().ThrowAsync<OperationCanceledException>();
    }

    [Fact]
    public async Task SendRequestAsync_WithEnumsFlag_SerializesCorrectly()
    {
        // Arrange
        var expectedResponse = new GetPlayerResponse
        {
            Name = "TestPlayer"
        };

        _mockHttp.When(HttpMethod.Post, "http://localhost:3000/player")
            .WithPartialContent("\"enums\":true")
            .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        var request = new GetPlayerRequest
        {
            Payload = new GetPlayerRequestPayload
            {
                AllyCode = "123456789"
            },
            Enums = true
        };

        // Act
        var result = await _client.SendRequestAsync<GetPlayerRequest, GetPlayerResponse>(request);

        // Assert
        result.Should().NotBeNull();
    }

    [Fact]
    public async Task SendRequestAsync_EmptyJsonObject_ReturnsEmptyObject()
    {
        // Arrange
        _mockHttp.When(HttpMethod.Get, "http://localhost:3000/enums")
            .Respond("application/json", "{}");

        var request = new GetEnumsRequest();

        // Act
        var result = await _client.SendRequestAsync<GetEnumsRequest, GetEnumsResponse>(request);

        // Assert
        result.Should().NotBeNull();
        result.Enums.Should().BeNull();
    }
}