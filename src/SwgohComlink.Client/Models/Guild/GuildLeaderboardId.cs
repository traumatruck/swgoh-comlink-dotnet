using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class GuildLeaderboardId
{
    [JsonPropertyName("leaderboardType")] public GuildLeaderboardType LeaderboardType { get; set; }

    [JsonPropertyName("defId")] public string? DefId { get; set; }

    [JsonPropertyName("monthOffset")] public int? MonthOffset { get; set; }
}