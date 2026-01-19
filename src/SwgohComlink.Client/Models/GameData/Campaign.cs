using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class Campaign
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("descriptionKey")]
    public string? DescriptionKey { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("campaignType")]
    public CampaignType CampaignType { get; set; }

    [JsonPropertyName("campaignMap")]
    public List<CampaignMap> CampaignMap { get; set; }

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