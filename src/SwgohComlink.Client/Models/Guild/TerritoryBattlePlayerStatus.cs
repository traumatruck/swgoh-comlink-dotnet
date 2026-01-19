using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryBattlePlayerStatus
{
    [JsonPropertyName("zoneStatus")]
    public List<TerritoryPlayerZoneStatus> ZoneStatus { get; set; }

    [JsonPropertyName("unitStatus")]
    public List<TerritoryPlayerUnitStatus> UnitStatus { get; set; }

    [JsonPropertyName("datacronStatus")]
    public List<TerritoryPlayerDatacronStatus> DatacronStatus { get; set; }

}