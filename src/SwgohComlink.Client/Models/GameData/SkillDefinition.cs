using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class SkillDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("iconKey")]
    public string? IconKey { get; set; }

    [JsonPropertyName("tier")]
    public List<SkillTierDefinition> Tier { get; set; }

    [JsonPropertyName("abilityReference")]
    public string? AbilityReference { get; set; }

    [JsonPropertyName("skillType")]
    public SkillType SkillType { get; set; }

    [JsonPropertyName("isZeta")]
    public bool? IsZeta { get; set; }

    [JsonPropertyName("omicronMode")]
    public OmicronMode OmicronMode { get; set; }
}