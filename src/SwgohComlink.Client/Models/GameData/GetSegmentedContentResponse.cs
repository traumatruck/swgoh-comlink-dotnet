using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class GetSegmentedContentResponse
{
    [JsonPropertyName("content")]
    public SegmentedContent Content { get; set; }
}