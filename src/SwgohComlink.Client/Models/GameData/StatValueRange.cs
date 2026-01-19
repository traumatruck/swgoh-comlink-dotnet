using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class StatValueRange
{
    [JsonPropertyName("stat")]
    public UnitStat Stat { get; set; }

    [JsonPropertyName("battleStat")]
    public BattleUnitStateStat BattleStat { get; set; }

    [JsonPropertyName("min")]
    public StatValueRangeNumber Min { get; set; }

    [JsonPropertyName("max")]
    public StatValueRangeNumber Max { get; set; }

}