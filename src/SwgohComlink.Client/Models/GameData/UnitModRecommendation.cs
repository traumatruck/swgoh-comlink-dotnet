using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class UnitModRecommendation
{
    [JsonPropertyName("recommendationSetId")]
    public string? RecommendationSetId { get; set; }

    [JsonPropertyName("unitTier")]
    public UnitTier UnitTier { get; set; }

}