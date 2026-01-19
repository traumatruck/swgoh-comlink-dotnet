using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Requests;

public class GetMetaDataRequest
{
    [JsonPropertyName("payload")]
    public GetMetaDataRequestPayload Payload { get; set; }

    [JsonPropertyName("enums")]
    public bool? Enums { get; set; }

}