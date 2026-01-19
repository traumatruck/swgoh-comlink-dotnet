using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class CharacterDialog
{
    [JsonPropertyName("characterPrefab")]
    public string? CharacterPrefab { get; set; }

    [JsonPropertyName("animations")]
    public List<string?> Animations { get; set; }

    [JsonPropertyName("audioKey")]
    public string? AudioKey { get; set; }

    [JsonPropertyName("layout")]
    public string? Layout { get; set; }

    [JsonPropertyName("useHologramEffect")]
    public bool? UseHologramEffect { get; set; }
}