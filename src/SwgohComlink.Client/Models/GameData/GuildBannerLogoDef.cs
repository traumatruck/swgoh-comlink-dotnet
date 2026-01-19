using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class GuildBannerLogoDef
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("logo")]
    public string? Logo { get; set; }

    [JsonPropertyName("uiLogo")]
    public string? UiLogo { get; set; }

    [JsonPropertyName("hidden")]
    public bool? Hidden { get; set; }

}