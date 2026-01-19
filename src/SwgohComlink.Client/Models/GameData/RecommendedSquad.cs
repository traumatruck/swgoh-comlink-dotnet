using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class RecommendedSquad
{
    [JsonPropertyName("descriptionKey")]
    public string? DescriptionKey { get; set; }

    [JsonPropertyName("thumbnail")]
    public string? Thumbnail { get; set; }

    [JsonPropertyName("unitDefId")]
    public List<string?> UnitDefId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("showRequirement")]
    public Requirement ShowRequirement { get; set; }

    [JsonPropertyName("hideRequirement")]
    public Requirement HideRequirement { get; set; }

    [JsonPropertyName("actionLink")]
    public ActionLink ActionLink { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

}