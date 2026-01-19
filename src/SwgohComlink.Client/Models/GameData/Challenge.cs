using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class Challenge
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public ChallengeType Type { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("descKey")]
    public string? DescKey { get; set; }

    [JsonPropertyName("viewRequirement")]
    public Requirement ViewRequirement { get; set; }

    [JsonPropertyName("reward")]
    public List<BucketItem> Reward { get; set; }

    [JsonPropertyName("platformAchievementId")]
    public string? PlatformAchievementId { get; set; }

    [JsonPropertyName("actionLinkDef")]
    public ActionLink ActionLinkDef { get; set; }

    [JsonPropertyName("claimType")]
    public ChallengeClaimType ClaimType { get; set; }

    [JsonPropertyName("rewardType")]
    public ChallengeRewardType RewardType { get; set; }

    [JsonPropertyName("rewardRatio")]
    public double? RewardRatio { get; set; }

    [JsonPropertyName("task")]
    public List<ChallengeTask> Task { get; set; }

    [JsonPropertyName("messageGroup")]
    public ContextualMessageGroup MessageGroup { get; set; }

    [JsonPropertyName("styleId")]
    public string? StyleId { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("nextChallengeId")]
    public string? NextChallengeId { get; set; }

    [JsonPropertyName("rewardDialogKey")]
    public string? RewardDialogKey { get; set; }

    [JsonPropertyName("rewardRedirectToHome")]
    public bool? RewardRedirectToHome { get; set; }

    [JsonPropertyName("rewardDescKey")]
    public string? RewardDescKey { get; set; }

    [JsonPropertyName("starterGuildGraduation")]
    public bool? StarterGuildGraduation { get; set; }

    [JsonPropertyName("rewardPoints")]
    public int? RewardPoints { get; set; }

    [JsonPropertyName("detailsKey")]
    public string? DetailsKey { get; set; }

    [JsonPropertyName("hiddenInMainQuests")]
    public bool? HiddenInMainQuests { get; set; }

    [JsonPropertyName("claimRequirement")]
    public Requirement ClaimRequirement { get; set; }

    [JsonPropertyName("rewardPopupEnabled")]
    public bool? RewardPopupEnabled { get; set; }

    [JsonPropertyName("claimDisabled")]
    public bool? ClaimDisabled { get; set; }

    [JsonPropertyName("claimDisabledMessageKey")]
    public string? ClaimDisabledMessageKey { get; set; }

    [JsonPropertyName("descParameterKey")]
    public List<string?> DescParameterKey { get; set; }
}