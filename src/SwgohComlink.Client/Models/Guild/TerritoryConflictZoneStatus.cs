using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryConflictZoneStatus
{
    [JsonPropertyName("zoneStatus")]
    public TerritoryZoneStatus ZoneStatus { get; set; }
}