using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class CampaignMap
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("campaignNodeDifficultyGroup")]
    public List<CampaignNodeDifficultyGroup> CampaignNodeDifficultyGroup { get; set; }

    [JsonPropertyName("progress")]
    public CampaignElementProgress Progress { get; set; }

    [JsonPropertyName("entryOwnershipRequirement")]
    public List<BucketItem> EntryOwnershipRequirement { get; set; }

    [JsonPropertyName("unlockRequirementLocalizationKey")]
    public string? UnlockRequirementLocalizationKey { get; set; }

    [JsonPropertyName("isPlayerSquadSupplied")]
    public bool? IsPlayerSquadSupplied { get; set; }

    [JsonPropertyName("dailyBattleCapKey")]
    public string? DailyBattleCapKey { get; set; }

    [JsonPropertyName("entryCategoryAllowed")]
    public EntryCategoryAllowed EntryCategoryAllowed { get; set; }

    [JsonPropertyName("grindEnabled")]
    public bool? GrindEnabled { get; set; }

    [JsonPropertyName("gameModeKey")]
    public string? GameModeKey { get; set; }
}