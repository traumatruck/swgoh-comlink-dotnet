using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class CraftingMaterialDef
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("descKey")]
    public string? DescKey { get; set; }

    [JsonPropertyName("iconKey")]
    public string? IconKey { get; set; }

    [JsonPropertyName("sellValue")]
    public CurrencyItem SellValue { get; set; }

    [JsonPropertyName("lookupMission")]
    public List<LookupMission> LookupMission { get; set; }

    [JsonPropertyName("xpValue")]
    public int? XpValue { get; set; }

    [JsonPropertyName("type")]
    public MaterialType Type { get; set; }

    [JsonPropertyName("rarity")]
    public Rarity Rarity { get; set; }

    [JsonPropertyName("trainingCost")]
    public int? TrainingCost { get; set; }

    [JsonPropertyName("trainingCostMaxLevel")]
    public int? TrainingCostMaxLevel { get; set; }

    [JsonPropertyName("unitDefReference")]
    public string? UnitDefReference { get; set; }

    [JsonPropertyName("tier")]
    public UnitTier Tier { get; set; }

    [JsonPropertyName("obtainableTime")]
    public long? ObtainableTime { get; set; }

    [JsonPropertyName("raidLookup")]
    public List<LookupMission> RaidLookup { get; set; }

    [JsonPropertyName("actionLinkLookup")]
    public List<LookupActionLink> ActionLinkLookup { get; set; }

    [JsonPropertyName("recipeId")]
    public string? RecipeId { get; set; }

    [JsonPropertyName("raidImmediateLookup")]
    public List<LookupMission> RaidImmediateLookup { get; set; }
}