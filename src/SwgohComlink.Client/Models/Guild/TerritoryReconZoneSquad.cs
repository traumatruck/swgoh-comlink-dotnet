using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryReconZoneSquad
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("unit")]
    public List<TerritoryReconZoneUnit> Unit { get; set; }

}