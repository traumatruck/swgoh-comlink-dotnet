using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class GameEvent
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("summaryKey")]
    public string? SummaryKey { get; set; }

    [JsonPropertyName("descKey")]
    public string? DescKey { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("type")]
    public GameEventType Type { get; set; }

    [JsonPropertyName("instance")]
    public List<GameEventInstance> Instance { get; set; }

    [JsonPropertyName("status")]
    public GameEventStatus Status { get; set; }

    [JsonPropertyName("campaignElementIdentifier")]
    public CampaignElementIdentifier CampaignElementIdentifier { get; set; }

    [JsonPropertyName("squadType")]
    public SquadType SquadType { get; set; }

    [JsonPropertyName("previewKey")]
    public string? PreviewKey { get; set; }

    [JsonPropertyName("reviewKey")]
    public string? ReviewKey { get; set; }

    [JsonPropertyName("uiLocation")]
    public GameEventUILocation UiLocation { get; set; }

    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    [JsonPropertyName("defensiveSquadUsageCostEnabled")]
    public bool? DefensiveSquadUsageCostEnabled { get; set; }

    [JsonPropertyName("encounterMessage")]
    public List<ContextualMessageGroup> EncounterMessage { get; set; }

    [JsonPropertyName("environment")]
    public List<Environment> Environment { get; set; }

    [JsonPropertyName("descKeyUnitCriteriaMet")]
    public string? DescKeyUnitCriteriaMet { get; set; }

    [JsonPropertyName("defensiveSquadType")]
    public SquadType DefensiveSquadType { get; set; }

    [JsonPropertyName("combatType")]
    public CombatType CombatType { get; set; }

    [JsonPropertyName("imageEffect")]
    public string? ImageEffect { get; set; }

    [JsonPropertyName("unlockRequirementLocalizationKey")]
    public string? UnlockRequirementLocalizationKey { get; set; }

    [JsonPropertyName("territoryMapId")]
    public string? TerritoryMapId { get; set; }

    [JsonPropertyName("pushNotificationTitleKey")]
    public string? PushNotificationTitleKey { get; set; }

    [JsonPropertyName("pushNotificationDescKey")]
    public string? PushNotificationDescKey { get; set; }

    [JsonPropertyName("seasonDefId")]
    public string? SeasonDefId { get; set; }

    [JsonPropertyName("unlockRequirementId")]
    public string? UnlockRequirementId { get; set; }

    [JsonPropertyName("feat")]
    public List<Feat> Feat { get; set; }

    [JsonPropertyName("linkedStoreItemId")]
    public List<string?> LinkedStoreItemId { get; set; }

    [JsonPropertyName("factionImage")]
    public string? FactionImage { get; set; }

    [JsonPropertyName("detailsType")]
    public GameEventDetailsType DetailsType { get; set; }

    [JsonPropertyName("conquestId")]
    public string? ConquestId { get; set; }

    [JsonPropertyName("rankRewardPreview")]
    public List<RankRewardPreview> RankRewardPreview { get; set; }

    [JsonPropertyName("iconJoin")]
    public string? IconJoin { get; set; }

    [JsonPropertyName("iconSetDefense")]
    public string? IconSetDefense { get; set; }

    [JsonPropertyName("iconAttack")]
    public string? IconAttack { get; set; }

    [JsonPropertyName("marqueeUnitBaseId")]
    public string? MarqueeUnitBaseId { get; set; }

    [JsonPropertyName("marqueeUnitTexture")]
    public string? MarqueeUnitTexture { get; set; }

    [JsonPropertyName("hideCompleted")]
    public bool? HideCompleted { get; set; }

}