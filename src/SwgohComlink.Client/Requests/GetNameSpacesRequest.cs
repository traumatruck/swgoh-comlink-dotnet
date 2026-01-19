using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Requests;

public class GetNameSpacesRequest
{
    [JsonPropertyName("payload")]
    public GetNameSpacesRequestPayload Payload { get; set; }

    [JsonPropertyName("enums")]
    public bool? Enums { get; set; }

}