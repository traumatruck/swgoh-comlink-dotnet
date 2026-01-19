using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class AbilityReference
{
    [JsonPropertyName("abilityId")]
    public string? AbilityId { get; set; }

    [JsonPropertyName("requiredTier")]
    public UnitTier RequiredTier { get; set; }

    [JsonPropertyName("requiredRarity")]
    public Rarity RequiredRarity { get; set; }

    [JsonPropertyName("requiredSkillTier")]
    public int? RequiredSkillTier { get; set; }

    [JsonPropertyName("requiredRelicTier")]
    public RelicTier RequiredRelicTier { get; set; }

    [JsonPropertyName("overrideAlwaysDisplayInBattleUi")]
    public bool? OverrideAlwaysDisplayInBattleUi { get; set; }

    [JsonPropertyName("overrideIcon")]
    public string? OverrideIcon { get; set; }

    [JsonPropertyName("overrideNameKey")]
    public string? OverrideNameKey { get; set; }

    [JsonPropertyName("overrideDescKey")]
    public string? OverrideDescKey { get; set; }

    [JsonPropertyName("powerAdditiveTag")]
    public string? PowerAdditiveTag { get; set; }

    [JsonPropertyName("unlockRecipeId")]
    public string? UnlockRecipeId { get; set; }

    [JsonPropertyName("inheritMappingId")]
    public string? InheritMappingId { get; set; }

}