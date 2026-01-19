using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ConversionItem
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public ItemType Type { get; set; }

    [JsonPropertyName("pointValue")]
    public int? PointValue { get; set; }
}