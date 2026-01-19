using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TerritoryWarConflictZoneDefinition
{
    [JsonPropertyName("zoneDefinition")]
    public TerritoryZoneDefinition ZoneDefinition { get; set; }

    [JsonPropertyName("combatType")]
    public CombatType CombatType { get; set; }

    [JsonPropertyName("conflictImage")]
    public string? ConflictImage { get; set; }

    [JsonPropertyName("conflictRequirement")]
    public string? ConflictRequirement { get; set; }

    [JsonPropertyName("conflictDetail")]
    public string? ConflictDetail { get; set; }

    [JsonPropertyName("entryCategoryAllowed")]
    public EntryCategoryAllowed EntryCategoryAllowed { get; set; }

    [JsonPropertyName("defenseEntryCategoryAllowed")]
    public EntryCategoryAllowed DefenseEntryCategoryAllowed { get; set; }

    [JsonPropertyName("deployDefensiveSquadReward")]
    public TerritoryReward DeployDefensiveSquadReward { get; set; }

    [JsonPropertyName("offensiveWinReward")]
    public TerritoryReward OffensiveWinReward { get; set; }

    [JsonPropertyName("completeZoneReward")]
    public TerritoryReward CompleteZoneReward { get; set; }

    [JsonPropertyName("completeZoneRewardPerDefensiveSquad")]
    public TerritoryReward CompleteZoneRewardPerDefensiveSquad { get; set; }

    [JsonPropertyName("battleEnvironments")]
    public List<Environment> BattleEnvironments { get; set; }

    [JsonPropertyName("pointStructure")]
    public TerritoryWarPointStructure PointStructure { get; set; }
}