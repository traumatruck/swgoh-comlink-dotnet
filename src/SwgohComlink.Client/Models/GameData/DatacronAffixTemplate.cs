using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class DatacronAffixTemplate
{
    [JsonPropertyName("abilityId")]
    public string? AbilityId { get; set; }

    [JsonPropertyName("targetRule")]
    public string? TargetRule { get; set; }

    [JsonPropertyName("statType")]
    public UnitStat StatType { get; set; }

    [JsonPropertyName("statValueMin")]
    public long? StatValueMin { get; set; }

    [JsonPropertyName("statValueMax")]
    public long? StatValueMax { get; set; }

    [JsonPropertyName("minTier")]
    public int? MinTier { get; set; }

    [JsonPropertyName("maxTier")]
    public int? MaxTier { get; set; }

    [JsonPropertyName("tag")]
    public List<string?> Tag { get; set; }

    [JsonPropertyName("scopeIcon")]
    public string? ScopeIcon { get; set; }
}