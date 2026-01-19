using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ModRecommendationSetBonus
{
    [JsonPropertyName("modSetId")]
    public string? ModSetId { get; set; }

    [JsonPropertyName("quantity")]
    public int? Quantity { get; set; }

}