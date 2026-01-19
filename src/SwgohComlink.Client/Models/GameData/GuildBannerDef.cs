using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class GuildBannerDef
{
    [JsonPropertyName("logo")]
    public List<string?> Logo { get; set; }

    [JsonPropertyName("color")]
    public List<GuildBannerColorDef> Color { get; set; }

    [JsonPropertyName("logoDefinition")]
    public List<GuildBannerLogoDef> LogoDefinition { get; set; }
}