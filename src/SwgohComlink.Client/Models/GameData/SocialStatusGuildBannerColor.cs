using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class SocialStatusGuildBannerColor
{
    [JsonPropertyName("id")] public int? Id { get; set; }

    [JsonPropertyName("guildBannerColorId")]
    public string? GuildBannerColorId { get; set; }
}