using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class BucketItem
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public ItemType Type { get; set; }

    [JsonPropertyName("minQuantity")]
    public int? MinQuantity { get; set; }

    [JsonPropertyName("maxQuantity")]
    public int? MaxQuantity { get; set; }

    [JsonPropertyName("rarity")]
    public Rarity Rarity { get; set; }

    [JsonPropertyName("statMod")]
    public StatMod StatMod { get; set; }

    [JsonPropertyName("previewPriority")]
    public int? PreviewPriority { get; set; }

    [JsonPropertyName("unitLevel")]
    public int? UnitLevel { get; set; }

    [JsonPropertyName("unitTier")]
    public UnitTier UnitTier { get; set; }

    [JsonPropertyName("primaryReward")]
    public bool? PrimaryReward { get; set; }

}