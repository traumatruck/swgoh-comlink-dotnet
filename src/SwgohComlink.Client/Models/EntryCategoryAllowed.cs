using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class EntryCategoryAllowed
{
    [JsonPropertyName("categoryId")]
    public List<string?> CategoryId { get; set; }

    [JsonPropertyName("maximumAllowedUnitQuantity")]
    public int? MaximumAllowedUnitQuantity { get; set; }

    [JsonPropertyName("matchType")]
    public CategoryMatchType MatchType { get; set; }

    [JsonPropertyName("minimumRequiredUnitQuantity")]
    public int? MinimumRequiredUnitQuantity { get; set; }

    [JsonPropertyName("minimumUnitRarity")]
    public Rarity MinimumUnitRarity { get; set; }

    [JsonPropertyName("minimumOwnedUnitQuantity")]
    public int? MinimumOwnedUnitQuantity { get; set; }

    [JsonPropertyName("minimumUnitLevel")]
    public int? MinimumUnitLevel { get; set; }

    [JsonPropertyName("minimumUnitTier")]
    public UnitTier MinimumUnitTier { get; set; }

    [JsonPropertyName("maximumReinforcement")]
    public int? MaximumReinforcement { get; set; }

    [JsonPropertyName("commanderCategoryId")]
    public List<string?> CommanderCategoryId { get; set; }

    [JsonPropertyName("minimumReinforcement")]
    public int? MinimumReinforcement { get; set; }

    [JsonPropertyName("minimumGalacticPower")]
    public int? MinimumGalacticPower { get; set; }

    [JsonPropertyName("mandatoryRosterUnit")]
    public List<MandatoryRosterUnit> MandatoryRosterUnit { get; set; }

    [JsonPropertyName("excludeCategoryId")]
    public List<string?> ExcludeCategoryId { get; set; }

    [JsonPropertyName("minimumRelicTier")]
    public RelicTier MinimumRelicTier { get; set; }

    [JsonPropertyName("minimumModRarity")]
    public Rarity MinimumModRarity { get; set; }

    [JsonPropertyName("minimumAbilityLevelAvg")]
    public int? MinimumAbilityLevelAvg { get; set; }

    [JsonPropertyName("minimumAbilityLevelAll")]
    public int? MinimumAbilityLevelAll { get; set; }

    [JsonPropertyName("legendLimit")]
    public int? LegendLimit { get; set; }

    [JsonPropertyName("unitGuideMinimumRequiredUnitQuantity")]
    public int? UnitGuideMinimumRequiredUnitQuantity { get; set; }

    [JsonPropertyName("bigUnitLimit")]
    public int? BigUnitLimit { get; set; }

    [JsonPropertyName("mandatoryDatacron")]
    public MandatoryDatacron MandatoryDatacron { get; set; }

    [JsonPropertyName("eraExclusive")]
    public bool? EraExclusive { get; set; }

    [JsonPropertyName("minimumEraLevel")]
    public int? MinimumEraLevel { get; set; }
}