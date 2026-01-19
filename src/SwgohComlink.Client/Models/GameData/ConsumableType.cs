using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ConsumableType
{
    [JsonPropertyName("typeId")]
    public string? TypeId { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("descriptionKey")]
    public string? DescriptionKey { get; set; }

    [JsonPropertyName("iconKey")]
    public string? IconKey { get; set; }
}