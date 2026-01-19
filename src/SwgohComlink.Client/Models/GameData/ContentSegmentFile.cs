using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ContentSegmentFile
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("filters")]
    public string? Filters { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    [JsonPropertyName("size")]
    public int? Size { get; set; }

}