using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ConquestDifficulty
{
    [JsonPropertyName("minGp")]
    public int? MinGp { get; set; }

    [JsonPropertyName("sector")]
    public List<ConquestSector> Sector { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("id")]
    public CampaignNodeDifficulty Id { get; set; }

    [JsonPropertyName("rankRewardPreview")]
    public List<RankRewardPreview> RankRewardPreview { get; set; }

    [JsonPropertyName("immediateRankRewardPreview")]
    public List<RankRewardPreview> ImmediateRankRewardPreview { get; set; }

    [JsonPropertyName("recommendedMinGp")]
    public int? RecommendedMinGp { get; set; }

    [JsonPropertyName("premiumImmediateRankRewardPreview")]
    public List<RankRewardPreview> PremiumImmediateRankRewardPreview { get; set; }
}