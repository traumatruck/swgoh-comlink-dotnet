using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryCovertZoneStatus
{
    [JsonPropertyName("zoneStatus")]
    public TerritoryZoneStatus ZoneStatus { get; set; }

    [JsonPropertyName("playersParticipated")]
    public int? PlayersParticipated { get; set; }

    [JsonPropertyName("successfulAttempts")]
    public int? SuccessfulAttempts { get; set; }
}