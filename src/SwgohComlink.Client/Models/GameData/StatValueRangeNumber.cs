using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class StatValueRangeNumber
{
    [JsonPropertyName("value")]
    public int? Value { get; set; }

    [JsonPropertyName("inclusive")]
    public bool? Inclusive { get; set; }

}