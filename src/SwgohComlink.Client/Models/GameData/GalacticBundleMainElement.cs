using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class GalacticBundleMainElement
{
    [JsonPropertyName("page")]
    public List<GalacticBundleMainElementPage> Page { get; set; }

    [JsonPropertyName("elementType")]
    public GalacticBundleMainElementType ElementType { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("inventoryType")]
    public GalacticBundleMainElementInventoryType InventoryType { get; set; }
}