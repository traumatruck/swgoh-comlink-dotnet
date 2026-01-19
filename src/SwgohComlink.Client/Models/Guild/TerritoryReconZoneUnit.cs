using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryReconZoneUnit
{
    [JsonPropertyName("unitIdentifier")]
    public string? UnitIdentifier { get; set; }

    [JsonPropertyName("level")]
    public int? Level { get; set; }

    [JsonPropertyName("memberId")]
    public string? MemberId { get; set; }

    [JsonPropertyName("tier")]
    public UnitTier Tier { get; set; }

    [JsonPropertyName("unitRelicTier")]
    public RelicTier UnitRelicTier { get; set; }
}