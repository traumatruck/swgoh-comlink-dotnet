using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class GuildInviteStatus
{
    [JsonPropertyName("guildId")]
    public string? GuildId { get; set; }

    [JsonPropertyName("expireTime")]
    public long? ExpireTime { get; set; }

    [JsonPropertyName("playerId")]
    public string? PlayerId { get; set; }

    [JsonPropertyName("type")]
    public GuildInviteType Type { get; set; }

    [JsonPropertyName("leaderUnit")]
    public Unit LeaderUnit { get; set; }

    [JsonPropertyName("sentTime")]
    public long? SentTime { get; set; }

    [JsonPropertyName("playerLevel")]
    public int? PlayerLevel { get; set; }

    [JsonPropertyName("playerName")]
    public string? PlayerName { get; set; }
}