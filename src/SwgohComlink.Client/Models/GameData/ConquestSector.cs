using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ConquestSector
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("node")]
    public List<ConquestNode> Node { get; set; }

    [JsonPropertyName("prefabName")]
    public string? PrefabName { get; set; }

    [JsonPropertyName("artTile")]
    public string? ArtTile { get; set; }

    [JsonPropertyName("titleKey")]
    public string? TitleKey { get; set; }

    [JsonPropertyName("environmentTitleKey")]
    public string? EnvironmentTitleKey { get; set; }

    [JsonPropertyName("backgroundPrefabName")]
    public string? BackgroundPrefabName { get; set; }

}