using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class CampaignMissionEnemyPreview
{
    [JsonPropertyName("baseEnemyItem")]
    public BucketItem BaseEnemyItem { get; set; }

    [JsonPropertyName("enemyLevel")]
    public int? EnemyLevel { get; set; }

    [JsonPropertyName("enemyTier")]
    public UnitTier EnemyTier { get; set; }

    [JsonPropertyName("threatLevel")]
    public ThreatLevel ThreatLevel { get; set; }

    [JsonPropertyName("thumbnailName")]
    public string? ThumbnailName { get; set; }

    [JsonPropertyName("prefabName")]
    public string? PrefabName { get; set; }

    [JsonPropertyName("displayedEnemy")]
    public bool? DisplayedEnemy { get; set; }

    [JsonPropertyName("unitClass")]
    public UnitClass UnitClass { get; set; }

    [JsonPropertyName("enemyForceAlignment")]
    public ForceAlignment EnemyForceAlignment { get; set; }

    [JsonPropertyName("enemyRelicTier")]
    public RelicTier EnemyRelicTier { get; set; }

    [JsonPropertyName("zetaCount")]
    public int? ZetaCount { get; set; }

    [JsonPropertyName("isGalacticLegend")]
    public bool? IsGalacticLegend { get; set; }

    [JsonPropertyName("isUltimateUnlocked")]
    public bool? IsUltimateUnlocked { get; set; }

    [JsonPropertyName("omicronCount")]
    public int? OmicronCount { get; set; }

    [JsonPropertyName("eraLevel")]
    public int? EraLevel { get; set; }

    [JsonPropertyName("eraThumbnailName")]
    public string? EraThumbnailName { get; set; }
}