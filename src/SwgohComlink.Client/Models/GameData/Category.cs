using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class Category
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("descKey")]
    public string? DescKey { get; set; }

    [JsonPropertyName("visible")]
    public bool? Visible { get; set; }

    [JsonPropertyName("uiFilter")]
    public List<CombatType> UiFilter { get; set; }
}