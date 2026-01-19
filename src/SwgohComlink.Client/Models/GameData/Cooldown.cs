using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class Cooldown
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("refreshCost")]
    public BucketItem RefreshCost { get; set; }
}