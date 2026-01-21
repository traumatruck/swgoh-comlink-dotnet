using System.Net;
using System.Text.Json;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using RichardSzalay.MockHttp;
using SwgohComlink.Client.Models.GameData;
using SwgohComlink.Client.Models.Guild;
using SwgohComlink.Client.Models.Metrics;
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
    public async Task SendRequestAsync_HttpError_LogsErrorDetails()
    {
        // Arrange
        const string errorBody = "{\"error\": \"Internal server error\"}";
        _mockHttp.When(HttpMethod.Get, "http://localhost:3000/enums")
            .Respond(HttpStatusCode.InternalServerError, "application/json", errorBody);

        var request = new GetEnumsRequest();

        // Act
        var act = async () => await _client.SendRequestAsync<GetEnumsRequest, GetEnumsResponse>(request);

        // Assert
        await act.Should().ThrowAsync<HttpRequestException>();
        
        _loggerMock.Verify(
            x => x.Log(
                LogLevel.Error,
                It.IsAny<EventId>(),
                It.Is<It.IsAnyType>((v, t) => v.ToString()!.Contains("/enums") && 
                                              v.ToString()!.Contains("500") &&
                                              v.ToString()!.Contains(errorBody)),
                It.IsAny<Exception>(),
                It.IsAny<Func<It.IsAnyType, Exception?, string>>()),
            Times.Once);
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
    public async Task SendRequestAsync_NotFoundResponse_LogsErrorDetailsWithMethod()
    {
        // Arrange
        const string errorBody = "{\"error\": \"Player not found\"}";
        _mockHttp.When(HttpMethod.Post, "http://localhost:3000/player")
            .Respond(HttpStatusCode.NotFound, "application/json", errorBody);

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
        
        _loggerMock.Verify(
            x => x.Log(
                LogLevel.Error,
                It.IsAny<EventId>(),
                It.Is<It.IsAnyType>((v, t) => v.ToString()!.Contains("/player") && 
                                              v.ToString()!.Contains("404") &&
                                              v.ToString()!.Contains("POST") &&
                                              v.ToString()!.Contains(errorBody)),
                It.IsAny<Exception>(),
                It.IsAny<Func<It.IsAnyType, Exception?, string>>()),
            Times.Once);
    }

    [Fact]
    public async Task SendRequestAsync_BadRequest_LogsErrorDetailsWithReasonPhrase()
    {
        // Arrange
        const string errorBody = "{\"error\": \"Invalid payload\", \"details\": \"Missing required field\"}";
        _mockHttp.When(HttpMethod.Post, "http://localhost:3000/guild")
            .Respond(HttpStatusCode.BadRequest, "application/json", errorBody);

        var request = new GetGuildRequest
        {
            Payload = new GetGuildRequestPayload
            {
                GuildId = "invalid-guild-id"
            }
        };

        // Act
        var act = async () => await _client.SendRequestAsync<GetGuildRequest, GetGuildResponse>(request);

        // Assert
        await act.Should().ThrowAsync<HttpRequestException>();
        
        _loggerMock.Verify(
            x => x.Log(
                LogLevel.Error,
                It.IsAny<EventId>(),
                It.Is<It.IsAnyType>((v, t) => v.ToString()!.Contains("/guild") && 
                                              v.ToString()!.Contains("400") &&
                                              v.ToString()!.Contains("Bad Request") &&
                                              v.ToString()!.Contains(errorBody)),
                It.IsAny<Exception>(),
                It.IsAny<Func<It.IsAnyType, Exception?, string>>()),
            Times.Once);
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

    [Fact]
    public async Task SendRequestAsync_PlainTextResponse_ReturnsPlainSuccessResponse()
    {
        // Arrange
        const string prometheusMetrics = """
                                         # HELP swgoh_comlink_requests_total Total number of requests
                                         # TYPE swgoh_comlink_requests_total counter
                                         swgoh_comlink_requests_total{endpoint="player"} 100
                                         """;

        _mockHttp.When(HttpMethod.Get, "http://localhost:3000/metrics")
            .Respond("text/plain", prometheusMetrics);

        var request = new GetMetricsRequest();

        // Act
        var result = await _client.SendRequestAsync<GetMetricsRequest, PlainSuccessResponse>(request);

        // Assert
        result.Should().NotBeNull();
        result.Value.Should().Be(prometheusMetrics);
    }

    [Fact]
    public async Task SendRequestAsync_PlainTextResponse_DoesNotAttemptJsonDeserialization()
    {
        // Arrange - Content that would fail JSON deserialization
        const string invalidJsonContent = "# This starts with a hash and is not valid JSON";

        _mockHttp.When(HttpMethod.Get, "http://localhost:3000/metrics")
            .Respond("text/plain", invalidJsonContent);

        var request = new GetMetricsRequest();

        // Act
        var result = await _client.SendRequestAsync<GetMetricsRequest, PlainSuccessResponse>(request);

        // Assert - Should succeed without throwing JsonException
        result.Should().NotBeNull();
        result.Value.Should().Be(invalidJsonContent);
    }

    [Fact]
    public async Task SendRequestAsync_PlainTextResponse_EmptyContent_ThrowsInvalidOperationException()
    {
        // Arrange
        _mockHttp.When(HttpMethod.Get, "http://localhost:3000/metrics")
            .Respond("text/plain", "");

        var request = new GetMetricsRequest();

        // Act
        var act = async () => await _client.SendRequestAsync<GetMetricsRequest, PlainSuccessResponse>(request);

        // Assert
        await act.Should().ThrowAsync<InvalidOperationException>()
            .WithMessage("Empty response received from endpoint: /metrics");
    }

    [Fact]
    public async Task SendRequestAsync_PlainTextResponse_WhitespaceContent_ThrowsInvalidOperationException()
    {
        // Arrange
        _mockHttp.When(HttpMethod.Get, "http://localhost:3000/metrics")
            .Respond("text/plain", "   ");

        var request = new GetMetricsRequest();

        // Act
        var act = async () => await _client.SendRequestAsync<GetMetricsRequest, PlainSuccessResponse>(request);

        // Assert
        await act.Should().ThrowAsync<InvalidOperationException>()
            .WithMessage("Empty response received from endpoint: /metrics");
    }
}