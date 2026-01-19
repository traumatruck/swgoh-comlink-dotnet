using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryGuildProfile
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("logoBackground")]
    public string? LogoBackground { get; set; }

    [JsonPropertyName("bannerColorId")]
    public string? BannerColorId { get; set; }

    [JsonPropertyName("bannerLogoId")]
    public string? BannerLogoId { get; set; }

    [JsonPropertyName("guildGalacticPower")]
    public long? GuildGalacticPower { get; set; }

}