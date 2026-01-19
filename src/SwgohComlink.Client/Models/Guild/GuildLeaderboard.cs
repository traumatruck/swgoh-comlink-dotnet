using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class GuildLeaderboard
{
    [JsonPropertyName("guild")]
    public List<GuildProfile> Guild { get; set; }

    [JsonPropertyName("resetTimestamp")]
    public long? ResetTimestamp { get; set; }

    [JsonPropertyName("leaderboardId")]
    public GuildLeaderboardId LeaderboardId { get; set; }
}