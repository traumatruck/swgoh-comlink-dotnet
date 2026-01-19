using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class StorePromoDialog
{
    [JsonPropertyName("storeItemId")]
    public string? StoreItemId { get; set; }

    [JsonPropertyName("descriptionTexture")]
    public string? DescriptionTexture { get; set; }

    [JsonPropertyName("buttonKey")]
    public string? ButtonKey { get; set; }

    [JsonPropertyName("showPrice")]
    public bool? ShowPrice { get; set; }
}