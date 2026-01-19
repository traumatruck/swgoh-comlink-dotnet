using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class DatacronTemplateTier
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("affixTemplateSetId")]
    public List<string?> AffixTemplateSetId { get; set; }

    [JsonPropertyName("initialAffixTemplateSetIds")]
    public List<string?> InitialAffixTemplateSetIds { get; set; }

    [JsonPropertyName("requiredUnitTier")]
    public UnitTier RequiredUnitTier { get; set; }

    [JsonPropertyName("requiredRelicTier")]
    public RelicTier RequiredRelicTier { get; set; }

    [JsonPropertyName("overrideUpgradeCostRecipeId")]
    public string? OverrideUpgradeCostRecipeId { get; set; }

    [JsonPropertyName("overrideScopeIdentifier")]
    public DatacronScopeIdentifier OverrideScopeIdentifier { get; set; }

}