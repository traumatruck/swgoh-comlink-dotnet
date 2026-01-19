using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class GetGuildLeaderboardResponse
{
    [JsonPropertyName("leaderboard")]
    public List<GuildLeaderboard> Leaderboard { get; set; }
}