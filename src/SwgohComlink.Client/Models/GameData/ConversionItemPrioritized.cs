using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ConversionItemPrioritized
{
    [JsonPropertyName("item")]
    public ConversionItem Item { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }
}