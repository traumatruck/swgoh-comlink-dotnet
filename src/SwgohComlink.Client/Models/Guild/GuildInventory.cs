using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class GuildInventory
{
    [JsonPropertyName("currencyItem")]
    public List<CurrencyItem> CurrencyItem { get; set; }

    [JsonPropertyName("currentDailyLimit")]
    public List<CurrencyItem> CurrentDailyLimit { get; set; }

}