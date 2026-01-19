using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Requests;

public class GetPlayerArenaProfileRequest
{
    [JsonPropertyName("payload")]
    public GetPlayerRequestPayload Payload { get; set; }

    [JsonPropertyName("enums")]
    public bool? Enums { get; set; }

}