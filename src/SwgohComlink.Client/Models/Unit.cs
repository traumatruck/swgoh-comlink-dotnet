using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class Unit
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("definitionId")]
    public string? DefinitionId { get; set; }

    [JsonPropertyName("currentRarity")]
    public Rarity CurrentRarity { get; set; }

    [JsonPropertyName("currentLevel")]
    public int? CurrentLevel { get; set; }

    [JsonPropertyName("currentXp")]
    public int? CurrentXp { get; set; }

    [JsonPropertyName("promotionRecipeReference")]
    public string? PromotionRecipeReference { get; set; }

    [JsonPropertyName("skill")]
    public List<Skill> Skill { get; set; }

    [JsonPropertyName("unitStat")]
    public StatDef UnitStat { get; set; }

    [JsonPropertyName("equipment")]
    public List<EquipmentSlot> Equipment { get; set; }

    [JsonPropertyName("currentTier")]
    public UnitTier CurrentTier { get; set; }

    [JsonPropertyName("equippedStatModOld")]
    public List<string?> EquippedStatModOld { get; set; }

    [JsonPropertyName("equippedStatMod")]
    public List<StatMod> EquippedStatMod { get; set; }

    [JsonPropertyName("relic")]
    public Relic Relic { get; set; }

    [JsonPropertyName("purchasedAbilityId")]
    public List<string?> PurchasedAbilityId { get; set; }

}