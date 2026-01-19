using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryPlayerUnitStatus
{
    [JsonPropertyName("unitId")]
    public string? UnitId { get; set; }

    [JsonPropertyName("deployedZoneId")]
    public string? DeployedZoneId { get; set; }

}