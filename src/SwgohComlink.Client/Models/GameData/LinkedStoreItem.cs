using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class LinkedStoreItem
{
    [JsonPropertyName("linkId")]
    public string? LinkId { get; set; }

    [JsonPropertyName("storeItem")]
    public List<string?> StoreItem { get; set; }

    [JsonPropertyName("type")]
    public LinkedStoreItemType Type { get; set; }

    [JsonPropertyName("contextualStoreItem")]
    public List<ContextualStoreItem> ContextualStoreItem { get; set; }

}