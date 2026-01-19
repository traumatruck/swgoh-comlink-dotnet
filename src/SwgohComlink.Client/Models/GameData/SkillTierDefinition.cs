using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class SkillTierDefinition
{
    [JsonPropertyName("recipeId")] public string? RecipeId { get; set; }

    [JsonPropertyName("requiredUnitLevel")]
    public int? RequiredUnitLevel { get; set; }

    [JsonPropertyName("requiredUnitRarity")]
    public Rarity RequiredUnitRarity { get; set; }

    [JsonPropertyName("requiredUnitTier")] public UnitTier RequiredUnitTier { get; set; }

    [JsonPropertyName("powerOverrideTag")] public string? PowerOverrideTag { get; set; }

    [JsonPropertyName("requiredUnitRelicTier")]
    public RelicTier RequiredUnitRelicTier { get; set; }

    [JsonPropertyName("isZetaTier")] public bool? IsZetaTier { get; set; }

    [JsonPropertyName("isOmicronTier")] public bool? IsOmicronTier { get; set; }
}