using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ContextualStoreItem
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("storeItemId")]
    public List<string?> StoreItemId { get; set; }
}