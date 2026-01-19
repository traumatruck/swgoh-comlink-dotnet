using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class ModifierItem
{
    [JsonPropertyName("type")]
    public ItemType Type { get; set; }

    [JsonPropertyName("materialType")]
    public MaterialType MaterialType { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("category")]
    public string? Category { get; set; }
}