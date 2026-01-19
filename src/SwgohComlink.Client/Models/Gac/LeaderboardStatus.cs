using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Gac;

public class LeaderboardStatus
{
    [JsonPropertyName("rank")]
    public int? Rank { get; set; }

    [JsonPropertyName("rankDelta")]
    public int? RankDelta { get; set; }

    [JsonPropertyName("score")]
    public int? Score { get; set; }

    [JsonPropertyName("scoreDelta")]
    public int? ScoreDelta { get; set; }

    [JsonPropertyName("tier")]
    public int? Tier { get; set; }

}