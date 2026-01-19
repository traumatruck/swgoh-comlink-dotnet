using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class CampaignNodeMission
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("descKey")]
    public string? DescKey { get; set; }

    [JsonPropertyName("combatType")]
    public CombatType CombatType { get; set; }

    [JsonPropertyName("enemyPreview")]
    public List<BucketItem> EnemyPreview { get; set; }

    [JsonPropertyName("rewardPreview")]
    public List<BucketItem> RewardPreview { get; set; }

    [JsonPropertyName("campaignNodeEncounter")]
    public List<CampaignNodeEncounter> CampaignNodeEncounter { get; set; }

    [JsonPropertyName("audioKey")]
    public string? AudioKey { get; set; }

    [JsonPropertyName("progress")]
    public CampaignElementProgress Progress { get; set; }

    [JsonPropertyName("entryCostRequirement")]
    public List<BucketItem> EntryCostRequirement { get; set; }

    [JsonPropertyName("entryCategoryAllowed")]
    public EntryCategoryAllowed EntryCategoryAllowed { get; set; }

    [JsonPropertyName("shortNameKey")]
    public string? ShortNameKey { get; set; }

    [JsonPropertyName("groupNameKey")]
    public string? GroupNameKey { get; set; }

    [JsonPropertyName("groupImage")]
    public string? GroupImage { get; set; }

    [JsonPropertyName("unlockRequirementLocalizationKey")]
    public string? UnlockRequirementLocalizationKey { get; set; }

    [JsonPropertyName("cooldownKey")]
    public string? CooldownKey { get; set; }

    [JsonPropertyName("dailyBattleCapKey")]
    public string? DailyBattleCapKey { get; set; }

    [JsonPropertyName("firstCompleteRewardPreview")]
    public List<BucketItem> FirstCompleteRewardPreview { get; set; }

    [JsonPropertyName("enemyUnitPreview")]
    public List<CampaignMissionEnemyPreview> EnemyUnitPreview { get; set; }

    [JsonPropertyName("prefab")]
    public string? Prefab { get; set; }

    [JsonPropertyName("position")]
    public Position Position { get; set; }

    [JsonPropertyName("playerAbilityRef")]
    public List<AbilityReference> PlayerAbilityRef { get; set; }

    [JsonPropertyName("activateCost")]
    public List<BucketItem> ActivateCost { get; set; }

    [JsonPropertyName("rankRewardPreview")]
    public List<RankRewardPreview> RankRewardPreview { get; set; }

    [JsonPropertyName("detailImage")]
    public string? DetailImage { get; set; }

    [JsonPropertyName("detailDescKey")]
    public string? DetailDescKey { get; set; }

    [JsonPropertyName("raidConfigId")]
    public string? RaidConfigId { get; set; }

    [JsonPropertyName("dynamicDescription")]
    public List<DynamicDescription> DynamicDescription { get; set; }

    [JsonPropertyName("nodeDisplayItem")]
    public ItemType NodeDisplayItem { get; set; }

    [JsonPropertyName("grindEnabled")]
    public bool? GrindEnabled { get; set; }

    [JsonPropertyName("hasForcedAlly")]
    public bool? HasForcedAlly { get; set; }

    [JsonPropertyName("battleSupportAllowed")]
    public bool? BattleSupportAllowed { get; set; }

    [JsonPropertyName("autoBattleEnabled")]
    public bool? AutoBattleEnabled { get; set; }

    [JsonPropertyName("retreatEnabled")]
    public bool? RetreatEnabled { get; set; }

    [JsonPropertyName("forcedPlayerSquad")]
    public ForcedPlayerSquad ForcedPlayerSquad { get; set; }

    [JsonPropertyName("grantedAbilities")]
    public List<MissionGrantedAbility> GrantedAbilities { get; set; }

    [JsonPropertyName("cooldownConditionalOverrideKey")]
    public string? CooldownConditionalOverrideKey { get; set; }

    [JsonPropertyName("holonodePlanetPrefabName")]
    public string? HolonodePlanetPrefabName { get; set; }

    [JsonPropertyName("battleSpeedAdjustable")]
    public bool? BattleSpeedAdjustable { get; set; }

    [JsonPropertyName("requirementOverrideKey")]
    public string? RequirementOverrideKey { get; set; }

    [JsonPropertyName("simmableOverrideEnabled")]
    public bool? SimmableOverrideEnabled { get; set; }

    [JsonPropertyName("conditionalRewardsPreview")]
    public List<ConditionalBucket> ConditionalRewardsPreview { get; set; }

    [JsonPropertyName("conditionalEntryCostOverride")]
    public ConditionalBucket ConditionalEntryCostOverride { get; set; }

    [JsonPropertyName("recommendationKey")]
    public string? RecommendationKey { get; set; }

    [JsonPropertyName("instanceFirstCompleteRewardPreview")]
    public List<BucketItem> InstanceFirstCompleteRewardPreview { get; set; }

    [JsonPropertyName("overviewLocKey")]
    public string? OverviewLocKey { get; set; }

    [JsonPropertyName("recommendedGp")]
    public int? RecommendedGp { get; set; }

    [JsonPropertyName("battleDurationLimit")]
    public long? BattleDurationLimit { get; set; }

    [JsonPropertyName("recommendedUnitGp")]
    public int? RecommendedUnitGp { get; set; }

    [JsonPropertyName("volatileAccess")]
    public bool? VolatileAccess { get; set; }

    [JsonPropertyName("unlockRequirementId")]
    public string? UnlockRequirementId { get; set; }

    [JsonPropertyName("visibilityRequirementId")]
    public string? VisibilityRequirementId { get; set; }

    [JsonPropertyName("raidPointsStructure")]
    public RaidPointsStructure RaidPointsStructure { get; set; }

    [JsonPropertyName("featured")]
    public bool? Featured { get; set; }

    [JsonPropertyName("immediateRegularRankRewardPreview")]
    public List<RankRewardPreview> ImmediateRegularRankRewardPreview { get; set; }

    [JsonPropertyName("maxPointsPerAttempt")]
    public int? MaxPointsPerAttempt { get; set; }

    [JsonPropertyName("unitReplacement")]
    public List<UnitReplacement> UnitReplacement { get; set; }

    [JsonPropertyName("pveDatacronAllowed")]
    public bool? PveDatacronAllowed { get; set; }

    [JsonPropertyName("coliseumPointSource")]
    public List<string?> ColiseumPointSource { get; set; }

    [JsonPropertyName("recommendedEraLevel")]
    public int? RecommendedEraLevel { get; set; }
}