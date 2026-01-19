using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class SystemModifier
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("scaleItemModifier")]
    public ScaleItemModifier ScaleItemModifier { get; set; }

    [JsonPropertyName("location")]
    public List<ModifierLocation> Location { get; set; }

    [JsonPropertyName("additionalItemModifier")]
    public AdditionalItemModifier AdditionalItemModifier { get; set; }

    [JsonPropertyName("descKey")]
    public string? DescKey { get; set; }

    [JsonPropertyName("actionLink")]
    public ActionLink ActionLink { get; set; }
}