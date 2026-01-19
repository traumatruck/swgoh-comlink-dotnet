using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ConquestMission
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("battleDetails")]
    public BattleDetails BattleDetails { get; set; }

    [JsonPropertyName("entryCostRequirement")]
    public List<BucketItem> EntryCostRequirement { get; set; }

    [JsonPropertyName("rewardPreview")]
    public List<BucketItem> RewardPreview { get; set; }

    [JsonPropertyName("conditionalRewardsPreview")]
    public List<ConditionalBucket> ConditionalRewardsPreview { get; set; }

    [JsonPropertyName("instanceFirstCompleteRewardPreview")]
    public List<BucketItem> InstanceFirstCompleteRewardPreview { get; set; }

    [JsonPropertyName("recommendationKey")]
    public string? RecommendationKey { get; set; }

}