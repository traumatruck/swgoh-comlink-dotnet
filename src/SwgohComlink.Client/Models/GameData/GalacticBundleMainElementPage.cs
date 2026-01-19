using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class GalacticBundleMainElementPage
{
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("description")]
    public List<string?> Description { get; set; }

    [JsonPropertyName("sprite")]
    public List<string?> Sprite { get; set; }
}