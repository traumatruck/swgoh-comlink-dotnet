using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryWarSquad
{
    [JsonPropertyName("playerId")]
    public string? PlayerId { get; set; }

    [JsonPropertyName("playerName")]
    public string? PlayerName { get; set; }

    [JsonPropertyName("power")]
    public int? Power { get; set; }

    [JsonPropertyName("squad")]
    public Squad Squad { get; set; }

    [JsonPropertyName("squadId")]
    public string? SquadId { get; set; }

    [JsonPropertyName("squadStatus")]
    public TerritoryWarSquadStatus SquadStatus { get; set; }

    [JsonPropertyName("lockName")]
    public string? LockName { get; set; }

    [JsonPropertyName("successfulDefends")]
    public int? SuccessfulDefends { get; set; }

    [JsonPropertyName("crewInfo")]
    public List<UnitTierSummary> CrewInfo { get; set; }

}