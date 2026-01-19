using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class PlayerTitleDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("descKey")]
    public string? DescKey { get; set; }

    [JsonPropertyName("obtainable")]
    public bool? Obtainable { get; set; }

    [JsonPropertyName("hidden")]
    public bool? Hidden { get; set; }

    [JsonPropertyName("shortDescKey")]
    public string? ShortDescKey { get; set; }
}