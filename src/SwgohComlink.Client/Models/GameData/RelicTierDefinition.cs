using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class RelicTierDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("stat")]
    public StatDef Stat { get; set; }

    [JsonPropertyName("relicStatTable")]
    public string? RelicStatTable { get; set; }

    [JsonPropertyName("tier")]
    public RelicTier Tier { get; set; }
}