using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class BattleEnvironment
{
    [JsonPropertyName("prefab")]
    public string? Prefab { get; set; }

    [JsonPropertyName("audioPackage")]
    public List<string?> AudioPackage { get; set; }
}