using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class DailyActionCap
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("maxActions")]
    public int? MaxActions { get; set; }

    [JsonPropertyName("purchaseCost")]
    public List<BucketItem> PurchaseCost { get; set; }

    [JsonPropertyName("unlimitedPurchases")]
    public bool? UnlimitedPurchases { get; set; }

}