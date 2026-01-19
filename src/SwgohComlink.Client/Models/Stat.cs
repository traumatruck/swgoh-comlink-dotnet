using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class Stat
{
    [JsonPropertyName("unitStatId")]
    public UnitStat UnitStatId { get; set; }

    [JsonPropertyName("statValueDecimal")]
    public long? StatValueDecimal { get; set; }

    [JsonPropertyName("unscaledDecimalValue")]
    public long? UnscaledDecimalValue { get; set; }

    [JsonPropertyName("uiDisplayOverrideValue")]
    public long? UiDisplayOverrideValue { get; set; }

    [JsonPropertyName("scalar")]
    public long? Scalar { get; set; }
}