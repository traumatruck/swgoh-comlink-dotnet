using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TerritoryBonusZoneDefinition
{
    [JsonPropertyName("zoneDefinition")]
    public TerritoryZoneDefinition ZoneDefinition { get; set; }

    [JsonPropertyName("linkedBonusConflictId")]
    public string? LinkedBonusConflictId { get; set; }
}