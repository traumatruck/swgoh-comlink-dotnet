using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Requests;

public class GetGameDataRequestPayload
{
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    [JsonPropertyName("includePveUnits")]
    public bool? IncludePveUnits { get; set; }

    [JsonPropertyName("devicePlatform")]
    public string? DevicePlatform { get; set; }

    [JsonPropertyName("requestSegment")]
    public double? RequestSegment { get; set; }

    [JsonPropertyName("items")]
    public string? Items { get; set; }
}