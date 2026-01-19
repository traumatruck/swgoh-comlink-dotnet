using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class MysteryStatModDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("slotOld")]
    public StatModSlot SlotOld { get; set; }

    [JsonPropertyName("setId")]
    public string? SetId { get; set; }

    [JsonPropertyName("minRarity")]
    public Rarity MinRarity { get; set; }

    [JsonPropertyName("maxRarity")]
    public Rarity MaxRarity { get; set; }

    [JsonPropertyName("minTier")]
    public StatModTier MinTier { get; set; }

    [JsonPropertyName("maxTier")]
    public StatModTier MaxTier { get; set; }

    [JsonPropertyName("slot")]
    public List<StatModSlot> Slot { get; set; }

    [JsonPropertyName("descKey")]
    public string? DescKey { get; set; }

}