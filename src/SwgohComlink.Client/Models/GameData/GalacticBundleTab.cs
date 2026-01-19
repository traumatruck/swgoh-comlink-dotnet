using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class GalacticBundleTab
{
    [JsonPropertyName("mainElement")]
    public GalacticBundleMainElement MainElement { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("text")]
    public string? Text { get; set; }
}