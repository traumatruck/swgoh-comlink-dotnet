using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class SocialStatus
{
    [JsonPropertyName("chatIcons")]
    public List<SocialStatusIcon> ChatIcons { get; set; }

    [JsonPropertyName("chatTitles")]
    public List<SocialStatusTitle> ChatTitles { get; set; }

    [JsonPropertyName("guildLogo")]
    public List<SocialStatusGuildBannerLogo> GuildLogo { get; set; }

    [JsonPropertyName("guildColor")]
    public List<SocialStatusGuildBannerColor> GuildColor { get; set; }

    [JsonPropertyName("chatPortraits")]
    public List<SocialStatusPortrait> ChatPortraits { get; set; }
}