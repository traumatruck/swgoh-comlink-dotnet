using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class XpTableRow
{
    [JsonPropertyName("index")]
    public int? Index { get; set; }

    [JsonPropertyName("xp")]
    public int? Xp { get; set; }

}