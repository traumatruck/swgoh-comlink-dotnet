using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class AdditionalItemModifier
{
    [JsonPropertyName("addedItem")]
    public List<BucketItem> AddedItem { get; set; }
}