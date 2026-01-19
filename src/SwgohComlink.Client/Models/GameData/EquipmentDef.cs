using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class EquipmentDef
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("iconKey")]
    public string? IconKey { get; set; }

    [JsonPropertyName("requiredLevel")]
    public int? RequiredLevel { get; set; }

    [JsonPropertyName("equipmentStat")]
    public StatDef EquipmentStat { get; set; }

    [JsonPropertyName("recipeId")]
    public string? RecipeId { get; set; }

    [JsonPropertyName("tier")]
    public UnitTier Tier { get; set; }

    [JsonPropertyName("sellValue")]
    public CurrencyItem SellValue { get; set; }

    [JsonPropertyName("lookupMission")]
    public List<LookupMission> LookupMission { get; set; }

    [JsonPropertyName("mark")]
    public string? Mark { get; set; }

    [JsonPropertyName("obtainableTime")]
    public long? ObtainableTime { get; set; }

    [JsonPropertyName("raidLookup")]
    public List<LookupMission> RaidLookup { get; set; }

    [JsonPropertyName("type")]
    public EquipmentType Type { get; set; }

    [JsonPropertyName("actionLinkLookup")]
    public List<LookupActionLink> ActionLinkLookup { get; set; }

    [JsonPropertyName("requiredRarity")]
    public Rarity RequiredRarity { get; set; }

    [JsonPropertyName("findFlowDisabled")]
    public bool? FindFlowDisabled { get; set; }

    [JsonPropertyName("raidImmediateLookup")]
    public List<LookupMission> RaidImmediateLookup { get; set; }
}