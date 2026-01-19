using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ArtifactTierDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("rarity")]
    public Rarity Rarity { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("iconKey")]
    public string? IconKey { get; set; }
}