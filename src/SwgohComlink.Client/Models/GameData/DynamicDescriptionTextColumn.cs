using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class DynamicDescriptionTextColumn
{
    [JsonPropertyName("headerKey")]
    public string? HeaderKey { get; set; }

    [JsonPropertyName("bodyKey")]
    public string? BodyKey { get; set; }

    [JsonPropertyName("bodyAlignment")]
    public DynamicDescriptionTextAlignmentType BodyAlignment { get; set; }

    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}