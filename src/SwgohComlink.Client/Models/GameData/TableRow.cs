using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TableRow
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}