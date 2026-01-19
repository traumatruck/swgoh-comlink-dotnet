using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class StatModDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("slot")]
    public StatModSlot Slot { get; set; }

    [JsonPropertyName("setId")]
    public string? SetId { get; set; }

    [JsonPropertyName("rarity")]
    public Rarity Rarity { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("descKey")]
    public string? DescKey { get; set; }

    [JsonPropertyName("missionLookup")]
    public List<LookupMission> MissionLookup { get; set; }

    [JsonPropertyName("raidLookup")]
    public List<LookupMission> RaidLookup { get; set; }

    [JsonPropertyName("actionLinkLookup")]
    public List<LookupActionLink> ActionLinkLookup { get; set; }

    [JsonPropertyName("levelTableId")]
    public string? LevelTableId { get; set; }

    [JsonPropertyName("promotionId")]
    public string? PromotionId { get; set; }

    [JsonPropertyName("promotionRecipeId")]
    public string? PromotionRecipeId { get; set; }

    [JsonPropertyName("tierUpRecipeTableId")]
    public string? TierUpRecipeTableId { get; set; }

    [JsonPropertyName("overclockRecipeTableId")]
    public string? OverclockRecipeTableId { get; set; }

    [JsonPropertyName("rerollCapTableId")]
    public string? RerollCapTableId { get; set; }

    [JsonPropertyName("raidImmediateLookup")]
    public List<LookupMission> RaidImmediateLookup { get; set; }
}