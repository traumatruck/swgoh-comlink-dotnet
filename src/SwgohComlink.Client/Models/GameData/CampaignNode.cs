using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class CampaignNode
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("campaignNodeMission")]
    public List<CampaignNodeMission> CampaignNodeMission { get; set; }

    [JsonPropertyName("homePrefab")]
    public string? HomePrefab { get; set; }

    [JsonPropertyName("forceAlignment")]
    public ForceAlignment ForceAlignment { get; set; }

    [JsonPropertyName("dominantClass")]
    public UnitClass DominantClass { get; set; }

    [JsonPropertyName("combatType")]
    public CombatType CombatType { get; set; }

    [JsonPropertyName("isCannon")]
    public bool? IsCannon { get; set; }

    [JsonPropertyName("progress")]
    public CampaignElementProgress Progress { get; set; }

    [JsonPropertyName("unlockRequirementLocalizationKey")]
    public string? UnlockRequirementLocalizationKey { get; set; }

    [JsonPropertyName("dailyBattleCapKey")]
    public string? DailyBattleCapKey { get; set; }

    [JsonPropertyName("entryCategoryAllowed")]
    public EntryCategoryAllowed EntryCategoryAllowed { get; set; }

    [JsonPropertyName("cooldownKey")]
    public string? CooldownKey { get; set; }

    [JsonPropertyName("grindEnabled")]
    public bool? GrindEnabled { get; set; }

    [JsonPropertyName("cooldownConditionalOverrideKey")]
    public string? CooldownConditionalOverrideKey { get; set; }

    [JsonPropertyName("firstTimeFinishCost")]
    public List<BucketItem> FirstTimeFinishCost { get; set; }

}