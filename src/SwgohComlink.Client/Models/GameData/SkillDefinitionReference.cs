using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class SkillDefinitionReference
{
    [JsonPropertyName("skillId")]
    public string? SkillId { get; set; }

    [JsonPropertyName("requiredTier")]
    public UnitTier RequiredTier { get; set; }

    [JsonPropertyName("requiredRarity")]
    public Rarity RequiredRarity { get; set; }

    [JsonPropertyName("requiredRelicTier")]
    public RelicTier RequiredRelicTier { get; set; }
}