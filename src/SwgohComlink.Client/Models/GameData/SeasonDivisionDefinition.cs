using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class SeasonDivisionDefinition
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("minPower")]
    public int? MinPower { get; set; }

}