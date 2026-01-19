using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryWarPlayerStatus
{
    [JsonPropertyName("unitStatus")]
    public List<TerritoryPlayerUnitStatus> UnitStatus { get; set; }

    [JsonPropertyName("warRoster")]
    public List<UnitBattleStat> WarRoster { get; set; }

    [JsonPropertyName("datacronRoster")]
    public List<DatacronBattleStat> DatacronRoster { get; set; }

    [JsonPropertyName("datacronStatus")]
    public List<TerritoryPlayerDatacronStatus> DatacronStatus { get; set; }

}