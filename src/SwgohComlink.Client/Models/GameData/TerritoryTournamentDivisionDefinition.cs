using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TerritoryTournamentDivisionDefinition
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("icon")]
    public string? Icon { get; set; }
}