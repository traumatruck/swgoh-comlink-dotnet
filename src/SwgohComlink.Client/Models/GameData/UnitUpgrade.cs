using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class UnitUpgrade
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("level")]
    public int? Level { get; set; }

    [JsonPropertyName("rarity")]
    public Rarity Rarity { get; set; }

    [JsonPropertyName("tier")]
    public UnitTier Tier { get; set; }

    [JsonPropertyName("skillTier")]
    public int? SkillTier { get; set; }

    [JsonPropertyName("skillOverride")]
    public List<SkillUpgrade> SkillOverride { get; set; }

    [JsonPropertyName("relicTier")]
    public RelicTier RelicTier { get; set; }

    [JsonPropertyName("basicSkillTier")]
    public int? BasicSkillTier { get; set; }

    [JsonPropertyName("leaderSkillTier")]
    public int? LeaderSkillTier { get; set; }

    [JsonPropertyName("uniqueSkillTier")]
    public int? UniqueSkillTier { get; set; }

    [JsonPropertyName("specialSkillTier")]
    public int? SpecialSkillTier { get; set; }

    [JsonPropertyName("excludeZetaSkills")]
    public bool? ExcludeZetaSkills { get; set; }

    [JsonPropertyName("excludeOmicronSkills")]
    public bool? ExcludeOmicronSkills { get; set; }

    [JsonPropertyName("abilityDescriptiveTagSkillTier")]
    public List<TagTier> AbilityDescriptiveTagSkillTier { get; set; }
}