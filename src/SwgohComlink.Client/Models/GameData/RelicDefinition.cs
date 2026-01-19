using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class RelicDefinition
{
    [JsonPropertyName("relicTierDefinitionId")]
    public List<string?> RelicTierDefinitionId { get; set; }

    [JsonPropertyName("upgradeTableId")]
    public string? UpgradeTableId { get; set; }

    [JsonPropertyName("alignmentColorOverride")]
    public string? AlignmentColorOverride { get; set; }

    [JsonPropertyName("texture")]
    public string? Texture { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

}