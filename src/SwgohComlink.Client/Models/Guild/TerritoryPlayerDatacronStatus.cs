using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryPlayerDatacronStatus
{
    [JsonPropertyName("datacronId")]
    public string? DatacronId { get; set; }

    [JsonPropertyName("deployedZoneId")]
    public string? DeployedZoneId { get; set; }

}