using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Requests;

public class GetLocalizationBundleRequestPayload
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

}