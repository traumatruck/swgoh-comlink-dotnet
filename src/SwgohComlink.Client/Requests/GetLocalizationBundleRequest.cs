using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Requests;

public class GetLocalizationBundleRequest
{
    [JsonPropertyName("unzip")]
    public bool? Unzip { get; set; }

    [JsonPropertyName("payload")]
    public GetLocalizationBundleRequestPayload Payload { get; set; }

    [JsonPropertyName("enums")]
    public bool? Enums { get; set; }

}