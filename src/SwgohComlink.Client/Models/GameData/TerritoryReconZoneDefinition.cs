using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TerritoryReconZoneDefinition
{
    [JsonPropertyName("zoneDefinition")]
    public TerritoryZoneDefinition ZoneDefinition { get; set; }

    [JsonPropertyName("platoonDefinition")]
    public List<TerritoryReconPlatoonDefinition> PlatoonDefinition { get; set; }

    [JsonPropertyName("abilityImage")]
    public string? AbilityImage { get; set; }

    [JsonPropertyName("abilityShortDescKey")]
    public string? AbilityShortDescKey { get; set; }

    [JsonPropertyName("abilityLongDescKey")]
    public string? AbilityLongDescKey { get; set; }

    [JsonPropertyName("goalDescKey")]
    public string? GoalDescKey { get; set; }

    [JsonPropertyName("goalImage")]
    public string? GoalImage { get; set; }

    [JsonPropertyName("unitRarity")]
    public Rarity UnitRarity { get; set; }

    [JsonPropertyName("rewardDescKey")]
    public string? RewardDescKey { get; set; }

    [JsonPropertyName("subTitleKey")]
    public string? SubTitleKey { get; set; }

    [JsonPropertyName("grantedAbilities")]
    public List<MissionGrantedAbility> GrantedAbilities { get; set; }

    [JsonPropertyName("strategicAbilities")]
    public List<MissionGrantedAbility> StrategicAbilities { get; set; }

    [JsonPropertyName("combatType")]
    public CombatType CombatType { get; set; }

    [JsonPropertyName("territoryBattleZoneUnitType")]
    public TerritoryBattleZoneUnitType TerritoryBattleZoneUnitType { get; set; }

    [JsonPropertyName("unitRelicTier")]
    public RelicTier UnitRelicTier { get; set; }

}