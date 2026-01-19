using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Requests;

public class GetSegmentedContentRequest
{
    [JsonPropertyName("payload")]
    public GetSegmentedContentRequestPayload Payload { get; set; }

    [JsonPropertyName("enums")]
    public bool? Enums { get; set; }

}