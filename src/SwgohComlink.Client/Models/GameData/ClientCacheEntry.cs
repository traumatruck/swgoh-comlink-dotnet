using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ClientCacheEntry
{
    [JsonPropertyName("domain")]
    public ClientCacheDomain Domain { get; set; }

    [JsonPropertyName("version")]
    public int? Version { get; set; }
}