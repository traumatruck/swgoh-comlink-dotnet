using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Requests;

public class GetLeaderboardRequest
{
    [JsonPropertyName("payload")]
    public GetLeaderboardRequestPayload Payload { get; set; }

    [JsonPropertyName("enums")]
    public bool? Enums { get; set; }

}