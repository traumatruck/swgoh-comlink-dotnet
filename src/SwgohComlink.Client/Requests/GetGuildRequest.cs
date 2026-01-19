using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Requests;

public class GetGuildRequest
{
    [JsonPropertyName("payload")]
    public GetGuildRequestPayload Payload { get; set; }

    [JsonPropertyName("enums")]
    public bool? Enums { get; set; }

}