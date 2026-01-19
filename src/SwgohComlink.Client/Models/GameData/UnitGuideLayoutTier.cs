using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class UnitGuideLayoutTier
{
    [JsonPropertyName("titleKey")]
    public string? TitleKey { get; set; }

    [JsonPropertyName("subtitleKey")]
    public string? SubtitleKey { get; set; }

    [JsonPropertyName("layoutLine")]
    public List<UnitGuideLayoutLine> LayoutLine { get; set; }

}