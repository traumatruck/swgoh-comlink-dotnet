using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryReconZonePlatoon
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("squad")]
    public List<TerritoryReconZoneSquad> Squad { get; set; }
}