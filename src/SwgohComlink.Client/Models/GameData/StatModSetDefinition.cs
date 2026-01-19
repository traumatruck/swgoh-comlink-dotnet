using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class StatModSetDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    [JsonPropertyName("completeBonus")]
    public StatModSetBonus CompleteBonus { get; set; }

    [JsonPropertyName("maxLevelBonus")]
    public StatModSetBonus MaxLevelBonus { get; set; }

    [JsonPropertyName("setCount")]
    public int? SetCount { get; set; }

    [JsonPropertyName("overclockBonus")]
    public StatModSetBonus OverclockBonus { get; set; }

}