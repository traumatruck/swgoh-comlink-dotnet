using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Requests;

public class GetGameDataRequest
{
    [JsonPropertyName("payload")]
    public GetGameDataRequestPayload Payload { get; set; }

    [JsonPropertyName("enums")]
    public bool? Enums { get; set; }

}