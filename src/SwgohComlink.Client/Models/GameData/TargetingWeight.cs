using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TargetingWeight
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("param")]
    public string? Param { get; set; }

    [JsonPropertyName("valueDecimal")]
    public int? ValueDecimal { get; set; }

}