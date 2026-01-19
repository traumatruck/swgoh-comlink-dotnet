using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class GalacticBundle
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("targetPlayerLevel")]
    public int? TargetPlayerLevel { get; set; }

    [JsonPropertyName("unitUpgrade")]
    public List<UnitUpgrade> UnitUpgrade { get; set; }

    [JsonPropertyName("tabs")]
    public List<GalacticBundleTab> Tabs { get; set; }

    [JsonPropertyName("inventoryItem")]
    public List<BucketItem> InventoryItem { get; set; }

    [JsonPropertyName("info")]
    public string? Info { get; set; }

    [JsonPropertyName("primaryGalacticBundle")]
    public bool? PrimaryGalacticBundle { get; set; }

}