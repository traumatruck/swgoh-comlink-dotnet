using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TagTier
{
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    [JsonPropertyName("tier")]
    public int? Tier { get; set; }

}