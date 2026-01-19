using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class Environment
{
    [JsonPropertyName("prefab")]
    public string? Prefab { get; set; }

    [JsonPropertyName("layout")]
    public string? Layout { get; set; }

    [JsonPropertyName("layoutPrefab")]
    public string? LayoutPrefab { get; set; }
}