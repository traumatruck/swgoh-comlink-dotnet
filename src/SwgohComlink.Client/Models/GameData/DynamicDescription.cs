using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class DynamicDescription
{
    [JsonPropertyName("descriptionType")]
    public DynamicDescriptionType DescriptionType { get; set; }

    [JsonPropertyName("unitTexture")]
    public string? UnitTexture { get; set; }

    [JsonPropertyName("unitNameKey")]
    public string? UnitNameKey { get; set; }

    [JsonPropertyName("abilityNameKey")]
    public string? AbilityNameKey { get; set; }

    [JsonPropertyName("abilityDescriptionKey")]
    public string? AbilityDescriptionKey { get; set; }

    [JsonPropertyName("abilityTexture")]
    public string? AbilityTexture { get; set; }

    [JsonPropertyName("headerKey")]
    public string? HeaderKey { get; set; }

    [JsonPropertyName("textKey")]
    public string? TextKey { get; set; }

    [JsonPropertyName("marginLeft")]
    public int? MarginLeft { get; set; }

    [JsonPropertyName("textColumn")]
    public List<DynamicDescriptionTextColumn> TextColumn { get; set; }

    [JsonPropertyName("textAlignment")]
    public DynamicDescriptionTextAlignmentType TextAlignment { get; set; }

    [JsonPropertyName("backgroundOverrideSprite")]
    public string? BackgroundOverrideSprite { get; set; }
}