using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ModRecommendation
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("setRecommendation")]
    public List<ModRecommendationSetBonus> SetRecommendation { get; set; }

    [JsonPropertyName("primaryStatRecommendation")]
    public List<ModRecommendationPrimaryStat> PrimaryStatRecommendation { get; set; }

    [JsonPropertyName("secondaryStatRecommendation")]
    public List<UnitStat> SecondaryStatRecommendation { get; set; }

    [JsonPropertyName("tipKey")]
    public string? TipKey { get; set; }
}