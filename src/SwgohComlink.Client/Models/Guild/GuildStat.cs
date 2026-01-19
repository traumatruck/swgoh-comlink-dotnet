using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class GuildStat
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("value")]
    public long? Value { get; set; }
}