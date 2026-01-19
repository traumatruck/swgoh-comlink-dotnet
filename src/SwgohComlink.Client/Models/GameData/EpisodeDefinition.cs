using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class EpisodeDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("startTime")]
    public long? StartTime { get; set; }

    [JsonPropertyName("endTime")]
    public long? EndTime { get; set; }

    [JsonPropertyName("regularImmediateRankRewardPreview")]
    public List<RankRewardPreview> RegularImmediateRankRewardPreview { get; set; }

    [JsonPropertyName("premiumImmediateRankRewardPreview")]
    public List<RankRewardPreview> PremiumImmediateRankRewardPreview { get; set; }

    [JsonPropertyName("repeatableMilestone")]
    public RepeatableMilestone RepeatableMilestone { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("episodeQuestBlock")]
    public List<QuestBlockDefinition> EpisodeQuestBlock { get; set; }

    [JsonPropertyName("characterQuestLine")]
    public List<CharacterQuestLine> CharacterQuestLine { get; set; }

    [JsonPropertyName("objectivesViewBackground")]
    public string? ObjectivesViewBackground { get; set; }

    [JsonPropertyName("purchasePassPopupBackground")]
    public string? PurchasePassPopupBackground { get; set; }

    [JsonPropertyName("episodePassIcon")]
    public string? EpisodePassIcon { get; set; }

    [JsonPropertyName("purchasePassPopupCenterImageBack")]
    public string? PurchasePassPopupCenterImageBack { get; set; }

    [JsonPropertyName("purchasePassPopupCenterImageFront")]
    public string? PurchasePassPopupCenterImageFront { get; set; }

    [JsonPropertyName("episodePassIconFree")]
    public string? EpisodePassIconFree { get; set; }

    [JsonPropertyName("episodePassIconPremium")]
    public string? EpisodePassIconPremium { get; set; }

    [JsonPropertyName("introQuestBlock")]
    public List<QuestBlockDefinition> IntroQuestBlock { get; set; }
}