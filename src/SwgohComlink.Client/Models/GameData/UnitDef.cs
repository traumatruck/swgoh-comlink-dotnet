using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class UnitDef
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("unitPrefab")]
    public string? UnitPrefab { get; set; }

    [JsonPropertyName("thumbnailName")]
    public string? ThumbnailName { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("rarity")]
    public Rarity Rarity { get; set; }

    [JsonPropertyName("maxRarity")]
    public Rarity MaxRarity { get; set; }

    [JsonPropertyName("forceAlignment")]
    public ForceAlignment ForceAlignment { get; set; }

    [JsonPropertyName("xpTableId")]
    public string? XpTableId { get; set; }

    [JsonPropertyName("actionCountMin")]
    public int? ActionCountMin { get; set; }

    [JsonPropertyName("actionCountMax")]
    public int? ActionCountMax { get; set; }

    [JsonPropertyName("combatType")]
    public CombatType CombatType { get; set; }

    [JsonPropertyName("descKey")]
    public string? DescKey { get; set; }

    [JsonPropertyName("threatLevel")]
    public ThreatLevel ThreatLevel { get; set; }

    [JsonPropertyName("obtainable")]
    public bool? Obtainable { get; set; }

    [JsonPropertyName("baseId")]
    public string? BaseId { get; set; }

    [JsonPropertyName("promotionRecipeReference")]
    public string? PromotionRecipeReference { get; set; }

    [JsonPropertyName("statProgressionId")]
    public string? StatProgressionId { get; set; }

    [JsonPropertyName("categoryId")]
    public List<string?> CategoryId { get; set; }

    [JsonPropertyName("trainingXpWorthBaseValueOverride")]
    public int? TrainingXpWorthBaseValueOverride { get; set; }

    [JsonPropertyName("maxLevelOverride")]
    public int? MaxLevelOverride { get; set; }

    [JsonPropertyName("trainingCostMultiplierOverride")]
    public int? TrainingCostMultiplierOverride { get; set; }

    [JsonPropertyName("creationRecipeReference")]
    public string? CreationRecipeReference { get; set; }

    [JsonPropertyName("skillReference")]
    public List<SkillDefinitionReference> SkillReference { get; set; }

    [JsonPropertyName("basePower")]
    public int? BasePower { get; set; }

    [JsonPropertyName("baseStat")]
    public StatDef BaseStat { get; set; }

    [JsonPropertyName("primaryStat")]
    public string? PrimaryStat { get; set; }

    [JsonPropertyName("unitTier")]
    public List<UnitTierDef> UnitTier { get; set; }

    [JsonPropertyName("basicAttack")]
    public Ability BasicAttack { get; set; }

    [JsonPropertyName("leaderAbility")]
    public Ability LeaderAbility { get; set; }

    [JsonPropertyName("limitBreak")]
    public List<Ability> LimitBreak { get; set; }

    [JsonPropertyName("uniqueAbility")]
    public List<Ability> UniqueAbility { get; set; }

    [JsonPropertyName("basicAttackRef")]
    public AbilityReference BasicAttackRef { get; set; }

    [JsonPropertyName("leaderAbilityRef")]
    public AbilityReference LeaderAbilityRef { get; set; }

    [JsonPropertyName("limitBreakRef")]
    public List<AbilityReference> LimitBreakRef { get; set; }

    [JsonPropertyName("uniqueAbilityRef")]
    public List<AbilityReference> UniqueAbilityRef { get; set; }

    [JsonPropertyName("primaryUnitStat")]
    public UnitStat PrimaryUnitStat { get; set; }

    [JsonPropertyName("obtainableTime")]
    public long? ObtainableTime { get; set; }

    [JsonPropertyName("crew")]
    public List<CrewMember> Crew { get; set; }

    [JsonPropertyName("commandCost")]
    public int? CommandCost { get; set; }

    [JsonPropertyName("crewContributionTableId")]
    public string? CrewContributionTableId { get; set; }

    [JsonPropertyName("unitClass")]
    public UnitClass UnitClass { get; set; }

    [JsonPropertyName("battlePortraitPrefab")]
    public string? BattlePortraitPrefab { get; set; }

    [JsonPropertyName("battlePortraitNameKey")]
    public string? BattlePortraitNameKey { get; set; }

    [JsonPropertyName("modRecommendation")]
    public List<UnitModRecommendation> ModRecommendation { get; set; }

    [JsonPropertyName("effectIconPriorityOverride")]
    public List<string?> EffectIconPriorityOverride { get; set; }

    [JsonPropertyName("summonStatTable")]
    public List<SummonStatTable> SummonStatTable { get; set; }

    [JsonPropertyName("relicDefinition")]
    public RelicDefinition RelicDefinition { get; set; }

    [JsonPropertyName("capitalUnlockKey")]
    public string? CapitalUnlockKey { get; set; }

    [JsonPropertyName("legend")]
    public bool? Legend { get; set; }

    [JsonPropertyName("squadPositionPriority")]
    public int? SquadPositionPriority { get; set; }

    [JsonPropertyName("exampleSquad")]
    public List<RecommendedSquad> ExampleSquad { get; set; }

    [JsonPropertyName("big")]
    public bool? Big { get; set; }

    [JsonPropertyName("hideInTurnOrder")]
    public bool? HideInTurnOrder { get; set; }

    [JsonPropertyName("thumbImageTurnOrder")]
    public string? ThumbImageTurnOrder { get; set; }

    [JsonPropertyName("requireUltimateUnlock")]
    public bool? RequireUltimateUnlock { get; set; }

    [JsonPropertyName("battlePortraitTexture")]
    public string? BattlePortraitTexture { get; set; }

    [JsonPropertyName("eraThumbnailName")]
    public string? EraThumbnailName { get; set; }

    [JsonPropertyName("grantStartTime")]
    public long? GrantStartTime { get; set; }

    [JsonPropertyName("featuredEndTime")]
    public long? FeaturedEndTime { get; set; }

    [JsonPropertyName("associatedEventId")]
    public string? AssociatedEventId { get; set; }

    [JsonPropertyName("loanedUnit")]
    public bool? LoanedUnit { get; set; }

}