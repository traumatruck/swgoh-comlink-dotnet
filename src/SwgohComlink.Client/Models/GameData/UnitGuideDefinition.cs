using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class UnitGuideDefinition
{
    [JsonPropertyName("unitBaseId")]
    public string? UnitBaseId { get; set; }

    [JsonPropertyName("type")]
    public UnitGuideActivityType Type { get; set; }

    [JsonPropertyName("activityId")]
    public string? ActivityId { get; set; }

    [JsonPropertyName("descriptionKey")]
    public string? DescriptionKey { get; set; }

    [JsonPropertyName("recommendationRequirementId")]
    public string? RecommendationRequirementId { get; set; }

    [JsonPropertyName("overrideTexture")]
    public string? OverrideTexture { get; set; }

    [JsonPropertyName("titleKey")]
    public string? TitleKey { get; set; }

    [JsonPropertyName("subtitleKey")]
    public string? SubtitleKey { get; set; }

    [JsonPropertyName("additionalActivationRequirementId")]
    public string? AdditionalActivationRequirementId { get; set; }

    [JsonPropertyName("displayEnabled")]
    public bool? DisplayEnabled { get; set; }

    [JsonPropertyName("actionLinkImage")]
    public string? ActionLinkImage { get; set; }

    [JsonPropertyName("actionLink")]
    public string? ActionLink { get; set; }

    [JsonPropertyName("inPreview")]
    public bool? InPreview { get; set; }

    [JsonPropertyName("hiddenUnitCount")]
    public int? HiddenUnitCount { get; set; }

    [JsonPropertyName("previewArtImage")]
    public string? PreviewArtImage { get; set; }

    [JsonPropertyName("upcomingEventKey")]
    public string? UpcomingEventKey { get; set; }

    [JsonPropertyName("featured")]
    public bool? Featured { get; set; }

    [JsonPropertyName("campaignElementIdentifier")]
    public CampaignElementIdentifier CampaignElementIdentifier { get; set; }

    [JsonPropertyName("characterRecommendedEntryCategory")]
    public EntryCategoryAllowed CharacterRecommendedEntryCategory { get; set; }

    [JsonPropertyName("shipRecommendedEntryCategory")]
    public EntryCategoryAllowed ShipRecommendedEntryCategory { get; set; }

    [JsonPropertyName("galacticLegend")]
    public bool? GalacticLegend { get; set; }

    [JsonPropertyName("bannerImage")]
    public string? BannerImage { get; set; }

    [JsonPropertyName("bannerImageSubtextKey")]
    public string? BannerImageSubtextKey { get; set; }

    [JsonPropertyName("unitStagePrefab")]
    public string? UnitStagePrefab { get; set; }

}