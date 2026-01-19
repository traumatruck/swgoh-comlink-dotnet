using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class SeasonStatus
{
    [JsonPropertyName("seasonId")]
    public string? SeasonId { get; set; }

    [JsonPropertyName("eventInstanceId")]
    public string? EventInstanceId { get; set; }

    [JsonPropertyName("league")]
    public string? League { get; set; }

    [JsonPropertyName("wins")]
    public int? Wins { get; set; }

    [JsonPropertyName("losses")]
    public int? Losses { get; set; }

    [JsonPropertyName("seasonPoints")]
    public int? SeasonPoints { get; set; }

    [JsonPropertyName("division")]
    public int? Division { get; set; }

    [JsonPropertyName("joinTime")]
    public long? JoinTime { get; set; }

    [JsonPropertyName("endTime")]
    public long? EndTime { get; set; }

    [JsonPropertyName("remove")]
    public bool? Remove { get; set; }

    [JsonPropertyName("rank")]
    public int? Rank { get; set; }

}