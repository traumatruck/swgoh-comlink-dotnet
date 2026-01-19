using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Requests;

public class GetGuildsRequest
{
    [JsonPropertyName("payload")]
    public GetGuildsRequestPayload Payload { get; set; }

    [JsonPropertyName("enums")]
    public bool? Enums { get; set; }

}