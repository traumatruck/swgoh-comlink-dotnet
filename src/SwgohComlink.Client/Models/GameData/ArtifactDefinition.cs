using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ArtifactDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("powerLevel")]
    public int? PowerLevel { get; set; }

    [JsonPropertyName("grantedAbility")]
    public List<MissionGrantedAbility> GrantedAbility { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("descriptionKey")]
    public string? DescriptionKey { get; set; }

    [JsonPropertyName("texture")]
    public string? Texture { get; set; }

    [JsonPropertyName("targetedStat")]
    public List<TargetedStat> TargetedStat { get; set; }

    [JsonPropertyName("tierId")]
    public string? TierId { get; set; }
}