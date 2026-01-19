using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Player;

public class PlayerProfileStat
{
    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("versionKey")]
    public string? VersionKey { get; set; }

    [JsonPropertyName("value")]
    public long? Value { get; set; }

    [JsonPropertyName("index")]
    public int? Index { get; set; }

}