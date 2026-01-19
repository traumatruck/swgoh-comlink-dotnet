using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TerritoryBattleConflictZoneDefinition
{
    [JsonPropertyName("combatType")]
    public CombatType CombatType { get; set; }

    [JsonPropertyName("victoryPointRewards")]
    public List<TerritoryRewardBracket> VictoryPointRewards { get; set; }

    [JsonPropertyName("zoneDefinition")]
    public TerritoryZoneDefinition ZoneDefinition { get; set; }

    [JsonPropertyName("conflictImage")]
    public string? ConflictImage { get; set; }

    [JsonPropertyName("territoryBattleZoneUnitType")]
    public TerritoryBattleZoneUnitType TerritoryBattleZoneUnitType { get; set; }

    [JsonPropertyName("alternateChaseIcon")]
    public bool? AlternateChaseIcon { get; set; }

    [JsonPropertyName("forceAlignment")]
    public ForceAlignment ForceAlignment { get; set; }

    [JsonPropertyName("isBonus")]
    public bool? IsBonus { get; set; }

    [JsonPropertyName("isNewestBonusZone")]
    public bool? IsNewestBonusZone { get; set; }

    [JsonPropertyName("flipChaseIconX")]
    public bool? FlipChaseIconX { get; set; }

    [JsonPropertyName("flipChaseIconY")]
    public bool? FlipChaseIconY { get; set; }

}