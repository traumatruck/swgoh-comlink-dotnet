using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ContentSegment
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("files")]
    public List<ContentSegmentFile> Files { get; set; }
}