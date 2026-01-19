using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TargetedStat
{
    [JsonPropertyName("stat")]
    public Stat Stat { get; set; }

    [JsonPropertyName("targetRuleId")]
    public string? TargetRuleId { get; set; }

}