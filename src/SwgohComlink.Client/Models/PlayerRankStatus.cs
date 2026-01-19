using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class PlayerRankStatus
{
    [JsonPropertyName("leagueId")]
    public string? LeagueId { get; set; }

    [JsonPropertyName("divisionId")]
    public int? DivisionId { get; set; }
}