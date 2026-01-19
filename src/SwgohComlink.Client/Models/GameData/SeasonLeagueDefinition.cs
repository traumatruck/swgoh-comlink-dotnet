using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class SeasonLeagueDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    [JsonPropertyName("rank")]
    public int? Rank { get; set; }

    [JsonPropertyName("sprite")]
    public string? Sprite { get; set; }

    [JsonPropertyName("portraitFrame")]
    public string? PortraitFrame { get; set; }

}