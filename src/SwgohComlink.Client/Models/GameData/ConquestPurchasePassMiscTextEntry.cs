using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ConquestPurchasePassMiscTextEntry
{
    [JsonPropertyName("spriteName")]
    public string? SpriteName { get; set; }

    [JsonPropertyName("textId")]
    public string? TextId { get; set; }

    [JsonPropertyName("type")]
    public ConquestPurchasePassMiscTextEntryType Type { get; set; }
}