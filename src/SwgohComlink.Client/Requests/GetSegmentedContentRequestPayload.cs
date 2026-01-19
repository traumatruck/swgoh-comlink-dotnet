using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Requests;

public class GetSegmentedContentRequestPayload
{
    [JsonPropertyName("acceptLanguage")]
    public string? AcceptLanguage { get; set; }

    [JsonPropertyName("contentNameSpace")]
    public string? ContentNameSpace { get; set; }
}