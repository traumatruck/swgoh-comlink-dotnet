using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class CachedRaidRewards
{
    [JsonPropertyName("rankRewardPreview")]
    public List<RankRewardPreview> RankRewardPreview { get; set; }

    [JsonPropertyName("immediateRegularRankRewardPreview")]
    public List<RankRewardPreview> ImmediateRegularRankRewardPreview { get; set; }
}