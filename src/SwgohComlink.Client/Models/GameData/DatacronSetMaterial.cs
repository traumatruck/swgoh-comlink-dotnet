using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class DatacronSetMaterial
{
    [JsonPropertyName("materialId")]
    public string? MaterialId { get; set; }

    [JsonPropertyName("quantityPerDustGrant")]
    public int? QuantityPerDustGrant { get; set; }

    [JsonPropertyName("dustGrantRecipeId")]
    public string? DustGrantRecipeId { get; set; }
}