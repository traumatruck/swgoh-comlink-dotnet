using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class StarterGuildDef
{
    [JsonPropertyName("guildType")]
    public string? GuildType { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("allowedRaidId")]
    public List<string?> AllowedRaidId { get; set; }

    [JsonPropertyName("messageKey")]
    public string? MessageKey { get; set; }

    [JsonPropertyName("allowedRaidCampaignId")]
    public List<string?> AllowedRaidCampaignId { get; set; }

    [JsonPropertyName("bannerLogoId")]
    public string? BannerLogoId { get; set; }

    [JsonPropertyName("bannerColorId")]
    public string? BannerColorId { get; set; }

    [JsonPropertyName("externalMessageKey")]
    public string? ExternalMessageKey { get; set; }

    [JsonPropertyName("subNameKey")]
    public string? SubNameKey { get; set; }
}