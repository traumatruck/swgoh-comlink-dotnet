using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ConversionSet
{
    [JsonPropertyName("output")]
    public ConversionItemPrioritized Output { get; set; }

    [JsonPropertyName("consumable")]
    public List<ConversionItem> Consumable { get; set; }

    [JsonPropertyName("surplus")]
    public ConversionItem Surplus { get; set; }
}