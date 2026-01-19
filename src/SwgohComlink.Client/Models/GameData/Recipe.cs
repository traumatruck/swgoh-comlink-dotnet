using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class Recipe
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("descKey")]
    public string? DescKey { get; set; }

    [JsonPropertyName("result")]
    public BucketItem Result { get; set; }

    [JsonPropertyName("ingredients")]
    public List<BucketItem> Ingredients { get; set; }

    [JsonPropertyName("type")]
    public RecipeType Type { get; set; }

    [JsonPropertyName("viewRequirement")]
    public Requirement ViewRequirement { get; set; }

    [JsonPropertyName("unlockLevel")]
    public int? UnlockLevel { get; set; }

    [JsonPropertyName("craftRequirement")]
    public Requirement CraftRequirement { get; set; }

    [JsonPropertyName("requiredEraLevel")]
    public int? RequiredEraLevel { get; set; }
}