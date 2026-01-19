using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class UnitTierSummary
{
    [JsonPropertyName("baseId")]
    public string? BaseId { get; set; }

    [JsonPropertyName("tier")]
    public UnitTier Tier { get; set; }

    [JsonPropertyName("unitRelicTier")]
    public RelicTier UnitRelicTier { get; set; }
}