using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class GameEventInstance
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("startTime")]
    public long? StartTime { get; set; }

    [JsonPropertyName("endTime")]
    public long? EndTime { get; set; }

    [JsonPropertyName("displayStartTime")]
    public long? DisplayStartTime { get; set; }

    [JsonPropertyName("displayEndTime")]
    public long? DisplayEndTime { get; set; }

    [JsonPropertyName("timeLimited")]
    public bool? TimeLimited { get; set; }

    [JsonPropertyName("campaignElementIdentifier")]
    public CampaignElementIdentifier CampaignElementIdentifier { get; set; }

    [JsonPropertyName("rewardPreview")]
    public List<BucketItem> RewardPreview { get; set; }

    [JsonPropertyName("rankRewardPreview")]
    public List<RankRewardPreview> RankRewardPreview { get; set; }

    [JsonPropertyName("entryCategoryAllowed")]
    public EntryCategoryAllowed EntryCategoryAllowed { get; set; }

    [JsonPropertyName("defensiveSquadSize")]
    public int? DefensiveSquadSize { get; set; }

    [JsonPropertyName("unitDailyUsageCapKey")]
    public string? UnitDailyUsageCapKey { get; set; }

    [JsonPropertyName("rosterRefreshTime")]
    public long? RosterRefreshTime { get; set; }

    [JsonPropertyName("joined")]
    public bool? Joined { get; set; }

    [JsonPropertyName("summaryKey")]
    public string? SummaryKey { get; set; }

    [JsonPropertyName("rewardTime")]
    public long? RewardTime { get; set; }

    [JsonPropertyName("defensiveSquadSaveTimeLimit")]
    public long? DefensiveSquadSaveTimeLimit { get; set; }

    [JsonPropertyName("systemModifier")]
    public SystemModifier SystemModifier { get; set; }

    [JsonPropertyName("supportsPushNotifications")]
    public bool? SupportsPushNotifications { get; set; }

    [JsonPropertyName("linkedEventId")]
    public List<string?> LinkedEventId { get; set; }

}