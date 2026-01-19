using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryPlayerZoneStatus
{
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }

    [JsonPropertyName("attempt")]
    public int? Attempt { get; set; }
}