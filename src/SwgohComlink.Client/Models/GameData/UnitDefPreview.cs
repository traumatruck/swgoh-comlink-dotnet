using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class UnitDefPreview
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("thumbnailName")]
    public string? ThumbnailName { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("basicAttackRef")]
    public AbilityReference BasicAttackRef { get; set; }

    [JsonPropertyName("limitBreakRef")]
    public List<AbilityReference> LimitBreakRef { get; set; }

    [JsonPropertyName("uniqueAbilityRef")]
    public List<AbilityReference> UniqueAbilityRef { get; set; }

}