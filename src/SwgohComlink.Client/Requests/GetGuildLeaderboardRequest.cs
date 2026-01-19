using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Requests;

public class GetGuildLeaderboardRequest
{
    [JsonPropertyName("payload")]
    public GetGuildLeaderboardRequestPayload Payload { get; set; }

    [JsonPropertyName("enums")]
    public bool? Enums { get; set; }

}