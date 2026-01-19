using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Requests;

public class GetLeaderboardRequestPayload
{
    [JsonPropertyName("leaderboardType")]
    public double? LeaderboardType { get; set; }
}