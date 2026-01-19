using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class PersistentVfx
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("prefab")]
    public string? Prefab { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("lineOverride")]
    public string? LineOverride { get; set; }

}