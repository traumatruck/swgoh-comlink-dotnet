using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class GuildExchangeItem
{
    [JsonPropertyName("item")]
    public BucketItem Item { get; set; }
}