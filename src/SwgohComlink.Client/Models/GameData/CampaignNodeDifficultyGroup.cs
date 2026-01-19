using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class CampaignNodeDifficultyGroup
{
    [JsonPropertyName("campaignNodeDifficulty")]
    public CampaignNodeDifficulty CampaignNodeDifficulty { get; set; }

    [JsonPropertyName("campaignNode")]
    public List<CampaignNode> CampaignNode { get; set; }

    [JsonPropertyName("progress")]
    public CampaignElementProgress Progress { get; set; }

    [JsonPropertyName("unlockRequirementLocalizationKey")]
    public string? UnlockRequirementLocalizationKey { get; set; }

    [JsonPropertyName("dailyBattleCapKey")]
    public string? DailyBattleCapKey { get; set; }

    [JsonPropertyName("entryCategoryAllowed")]
    public EntryCategoryAllowed EntryCategoryAllowed { get; set; }

    [JsonPropertyName("grindEnabled")]
    public bool? GrindEnabled { get; set; }
}