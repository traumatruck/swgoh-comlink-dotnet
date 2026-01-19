using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TerritoryTournamentConflictZoneDefinition
{
    [JsonPropertyName("combatType")]
    public CombatType CombatType { get; set; }

    [JsonPropertyName("victoryPointRewards")]
    public List<TerritoryRewardBracket> VictoryPointRewards { get; set; }

    [JsonPropertyName("zoneDefinition")]
    public TerritoryZoneDefinition ZoneDefinition { get; set; }

}