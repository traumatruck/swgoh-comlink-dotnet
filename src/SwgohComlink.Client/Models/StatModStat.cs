using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class StatModStat
{
    [JsonPropertyName("stat")]
    public Stat Stat { get; set; }

    [JsonPropertyName("roll")]
    public List<string?> Roll { get; set; }

    [JsonPropertyName("statRolls")]
    public int? StatRolls { get; set; }

    [JsonPropertyName("statRollerBoundsMin")]
    public long? StatRollerBoundsMin { get; set; }

    [JsonPropertyName("statRollerBoundsMax")]
    public long? StatRollerBoundsMax { get; set; }

    [JsonPropertyName("unscaledRollValue")]
    public List<long?> UnscaledRollValue { get; set; }

}