using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class CurrencyItem
{
    [JsonPropertyName("currency")]
    public CurrencyType Currency { get; set; }

    [JsonPropertyName("quantity")]
    public long? Quantity { get; set; }

    [JsonPropertyName("bonusQuantity")]
    public int? BonusQuantity { get; set; }

}