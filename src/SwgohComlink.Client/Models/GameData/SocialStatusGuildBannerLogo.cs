using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class SocialStatusGuildBannerLogo
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("guildBannerLogoId")]
    public string? GuildBannerLogoId { get; set; }
}