using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryStatCovertZoneResult
{
    [JsonPropertyName("covertZoneId")]
    public string? CovertZoneId { get; set; }

    [JsonPropertyName("result")]
    public TerritoryCovertMissionResult Result { get; set; }
}