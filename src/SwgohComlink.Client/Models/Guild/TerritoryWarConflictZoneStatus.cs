using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryWarConflictZoneStatus
{
    [JsonPropertyName("zoneStatus")]
    public TerritoryZoneStatus ZoneStatus { get; set; }

    [JsonPropertyName("squadCapacity")]
    public int? SquadCapacity { get; set; }

    [JsonPropertyName("warSquad")]
    public List<TerritoryWarSquad> WarSquad { get; set; }

    [JsonPropertyName("squadCount")]
    public int? SquadCount { get; set; }

    [JsonPropertyName("defeatedSquadCount")]
    public int? DefeatedSquadCount { get; set; }
}