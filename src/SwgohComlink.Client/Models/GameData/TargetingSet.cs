using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TargetingSet
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("weight")]
    public List<TargetingWeight> Weight { get; set; }
}