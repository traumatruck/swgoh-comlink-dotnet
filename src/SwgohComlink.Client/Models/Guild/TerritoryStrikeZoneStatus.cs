using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryStrikeZoneStatus
{
    [JsonPropertyName("playersParticipated")]
    public int? PlayersParticipated { get; set; }

    [JsonPropertyName("zoneStatus")]
    public TerritoryZoneStatus ZoneStatus { get; set; }
}