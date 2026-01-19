using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class HelpTile
{
    [JsonPropertyName("textKey")]
    public string? TextKey { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("titleKey")]
    public string? TitleKey { get; set; }
}