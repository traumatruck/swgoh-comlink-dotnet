using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class EffectTargetCategoryCriteria
{
    [JsonPropertyName("exclude")]
    public bool? Exclude { get; set; }

    [JsonPropertyName("categoryId")]
    public List<string?> CategoryId { get; set; }

    [JsonPropertyName("category")]
    public List<EffectTargetCategory> Category { get; set; }

}