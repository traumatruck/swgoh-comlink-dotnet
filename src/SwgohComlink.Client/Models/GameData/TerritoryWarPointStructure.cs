using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TerritoryWarPointStructure
{
    [JsonPropertyName("deployDefensiveSquadReward")]
    public TerritoryReward DeployDefensiveSquadReward { get; set; }

    [JsonPropertyName("offensiveWinReward")]
    public TerritoryReward OffensiveWinReward { get; set; }

    [JsonPropertyName("completeZoneReward")]
    public TerritoryReward CompleteZoneReward { get; set; }

    [JsonPropertyName("completeZoneRewardPerDefensiveSquad")]
    public TerritoryReward CompleteZoneRewardPerDefensiveSquad { get; set; }

    [JsonPropertyName("defendDefeatBonus")]
    public List<GraduatingTerritoryReward> DefendDefeatBonus { get; set; }

    [JsonPropertyName("emptySquadSlotBonus")]
    public TerritoryReward EmptySquadSlotBonus { get; set; }

    [JsonPropertyName("survivingSquadUnitBonus")]
    public TerritoryReward SurvivingSquadUnitBonus { get; set; }

    [JsonPropertyName("fullHealthUnitBonus")]
    public TerritoryReward FullHealthUnitBonus { get; set; }

    [JsonPropertyName("fullProtectionUnitBonus")]
    public TerritoryReward FullProtectionUnitBonus { get; set; }

    [JsonPropertyName("firstAttackBonus")]
    public TerritoryReward FirstAttackBonus { get; set; }

    [JsonPropertyName("enemyDefeatedBonus")]
    public TerritoryReward EnemyDefeatedBonus { get; set; }
}