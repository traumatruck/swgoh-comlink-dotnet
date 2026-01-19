using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class DatacronAffix
{
    [JsonPropertyName("targetRule")]
    public string? TargetRule { get; set; }

    [JsonPropertyName("abilityId")]
    public string? AbilityId { get; set; }

    [JsonPropertyName("statType")]
    public UnitStat StatType { get; set; }

    [JsonPropertyName("statValue")]
    public long? StatValue { get; set; }

    [JsonPropertyName("tag")]
    public List<string?> Tag { get; set; }

    [JsonPropertyName("requiredUnitTier")]
    public UnitTier RequiredUnitTier { get; set; }

    [JsonPropertyName("requiredRelicTier")]
    public RelicTier RequiredRelicTier { get; set; }

    [JsonPropertyName("scopeIcon")]
    public string? ScopeIcon { get; set; }

}