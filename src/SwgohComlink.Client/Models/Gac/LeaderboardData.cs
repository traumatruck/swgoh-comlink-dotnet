using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Gac;

public class LeaderboardData
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("player")]
    public List<LeaderboardPlayer> Player { get; set; }

    [JsonPropertyName("playerStatus")]
    public LeaderboardStatus PlayerStatus { get; set; }

}