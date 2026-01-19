using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Requests;

public class GetMetaDataRequestPayloadClientSpecs
{
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    [JsonPropertyName("bundleId")]
    public string? BundleId { get; set; }

    [JsonPropertyName("externalVersion")]
    public string? ExternalVersion { get; set; }

    [JsonPropertyName("internalVersion")]
    public string? InternalVersion { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

}