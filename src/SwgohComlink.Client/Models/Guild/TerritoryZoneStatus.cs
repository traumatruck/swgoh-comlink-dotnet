using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryZoneStatus
{
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }

    [JsonPropertyName("zoneState")]
    public TerritoryZoneState ZoneState { get; set; }

    [JsonPropertyName("score")]
    public long? Score { get; set; }

    [JsonPropertyName("channelId")]
    public string? ChannelId { get; set; }

    [JsonPropertyName("commandMessage")]
    public string? CommandMessage { get; set; }

    [JsonPropertyName("commandState")]
    public TerritoryZoneCommandState CommandState { get; set; }
}