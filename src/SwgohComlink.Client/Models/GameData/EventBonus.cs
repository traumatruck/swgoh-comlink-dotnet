using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class EventBonus
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("descKey")]
    public string? DescKey { get; set; }

    [JsonPropertyName("iconKey")]
    public string? IconKey { get; set; }

    [JsonPropertyName("scoreModifier")]
    public double? ScoreModifier { get; set; }
}