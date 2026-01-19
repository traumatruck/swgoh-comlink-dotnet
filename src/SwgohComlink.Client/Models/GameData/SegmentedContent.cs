using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class SegmentedContent
{
    [JsonPropertyName("segments")]
    public List<ContentSegment> Segments { get; set; }
}