using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class DatacronTemplate
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("setId")]
    public int? SetId { get; set; }

    [JsonPropertyName("initialTiers")]
    public int? InitialTiers { get; set; }

    [JsonPropertyName("referenceTemplateId")]
    public string? ReferenceTemplateId { get; set; }

    [JsonPropertyName("fixedTag")]
    public List<string?> FixedTag { get; set; }

    [JsonPropertyName("tier")]
    public List<DatacronTemplateTier> Tier { get; set; }

    [JsonPropertyName("maxRerolls")]
    public int? MaxRerolls { get; set; }

    [JsonPropertyName("allowReroll")]
    public bool? AllowReroll { get; set; }

    [JsonPropertyName("focused")]
    public bool? Focused { get; set; }

    [JsonPropertyName("focusedIcon")]
    public string? FocusedIcon { get; set; }

    [JsonPropertyName("focusedPrefab")]
    public string? FocusedPrefab { get; set; }

}