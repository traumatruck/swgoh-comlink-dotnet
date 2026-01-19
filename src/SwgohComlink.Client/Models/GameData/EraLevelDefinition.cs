using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class EraLevelDefinition
{
    [JsonPropertyName("level")]
    public int? Level { get; set; }

    [JsonPropertyName("upgradeRecipeId")]
    public string? UpgradeRecipeId { get; set; }

    [JsonPropertyName("requiredRarity")]
    public Rarity RequiredRarity { get; set; }

    [JsonPropertyName("majorMilestone")]
    public bool? MajorMilestone { get; set; }

    [JsonPropertyName("currentUnitLevel")]
    public int? CurrentUnitLevel { get; set; }

    [JsonPropertyName("currentGearTier")]
    public UnitTier CurrentGearTier { get; set; }

    [JsonPropertyName("currentGearPieces")]
    public int? CurrentGearPieces { get; set; }

    [JsonPropertyName("currentRelicTier")]
    public RelicTier CurrentRelicTier { get; set; }

    [JsonPropertyName("currentAbilityLevel")]
    public int? CurrentAbilityLevel { get; set; }

}