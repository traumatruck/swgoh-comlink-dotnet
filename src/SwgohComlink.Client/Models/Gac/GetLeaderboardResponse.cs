using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Gac;

public class GetLeaderboardResponse
{
    [JsonPropertyName("player")]
    public List<LeaderboardPlayer> Player { get; set; }

    [JsonPropertyName("playerStatus")]
    public LeaderboardStatus PlayerStatus { get; set; }

    [JsonPropertyName("leaderboard")]
    public List<LeaderboardData> Leaderboard { get; set; }

}