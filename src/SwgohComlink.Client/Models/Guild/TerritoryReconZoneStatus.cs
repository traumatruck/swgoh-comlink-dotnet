using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryReconZoneStatus
{
    [JsonPropertyName("zoneStatus")]
    public TerritoryZoneStatus ZoneStatus { get; set; }

    [JsonPropertyName("platoon")]
    public List<TerritoryReconZonePlatoon> Platoon { get; set; }

}