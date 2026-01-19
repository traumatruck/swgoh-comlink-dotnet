using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class DatacronSetTier
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("upgradeCostRecipeId")]
    public string? UpgradeCostRecipeId { get; set; }

    [JsonPropertyName("dustGrantRecipeId")]
    public string? DustGrantRecipeId { get; set; }

    [JsonPropertyName("rerollCostRecipeId")]
    public List<string?> RerollCostRecipeId { get; set; }

    [JsonPropertyName("scopeIdentifier")]
    public DatacronScopeIdentifier ScopeIdentifier { get; set; }

}