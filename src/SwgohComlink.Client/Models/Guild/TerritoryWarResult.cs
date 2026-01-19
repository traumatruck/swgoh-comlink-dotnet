using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryWarResult
{
    [JsonPropertyName("territoryWarId")]
    public string? TerritoryWarId { get; set; }

    [JsonPropertyName("score")]
    public long? Score { get; set; }

    [JsonPropertyName("power")]
    public int? Power { get; set; }

    [JsonPropertyName("opponentScore")]
    public long? OpponentScore { get; set; }

    [JsonPropertyName("endTimeSeconds")]
    public long? EndTimeSeconds { get; set; }
}