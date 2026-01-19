using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class EffectTargetCategory
{
    [JsonPropertyName("exclude")]
    public bool? Exclude { get; set; }

    [JsonPropertyName("categoryId")]
    public string? CategoryId { get; set; }
}