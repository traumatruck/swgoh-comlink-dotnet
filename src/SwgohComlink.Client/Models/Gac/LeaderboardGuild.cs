using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Gac;

public class LeaderboardGuild
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("bannerColorId")]
    public string? BannerColorId { get; set; }

    [JsonPropertyName("bannerLogoId")]
    public string? BannerLogoId { get; set; }

    [JsonPropertyName("guildTypeId")]
    public string? GuildTypeId { get; set; }
}