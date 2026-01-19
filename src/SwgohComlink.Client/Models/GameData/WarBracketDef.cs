using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class WarBracketDef
{
    [JsonPropertyName("min")]
    public int? Min { get; set; }

    [JsonPropertyName("max")]
    public int? Max { get; set; }

    [JsonPropertyName("node")]
    public List<WarNodeDef> Node { get; set; }

}