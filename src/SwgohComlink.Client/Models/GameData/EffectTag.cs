using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class EffectTag
{
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    [JsonPropertyName("exclude")]
    public bool? Exclude { get; set; }

}