using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Requests;

public class GetGuildLeaderboardRequestPayload
{
    [JsonPropertyName("leaderboardId")]
    public List<GetGuildLeaderboardRequestPayloadLeaderboardIdItem> LeaderboardId { get; set; }

    [JsonPropertyName("count")]
    public double? Count { get; set; }
}