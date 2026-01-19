using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class Effect
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public EffectType Type { get; set; }

    [JsonPropertyName("param")]
    public List<string?> Param { get; set; }

    [JsonPropertyName("chance")]
    public int? Chance { get; set; }

    [JsonPropertyName("target")]
    public List<EffectTarget> Target { get; set; }

    [JsonPropertyName("descriptiveTag")]
    public List<EffectTag> DescriptiveTag { get; set; }

    [JsonPropertyName("effectedTag")]
    public List<EffectTag> EffectedTag { get; set; }

    [JsonPropertyName("triggerCondition")]
    public List<BattleCondition> TriggerCondition { get; set; }

    [JsonPropertyName("effectDefinition")]
    public List<Effect> EffectDefinition { get; set; }

    [JsonPropertyName("contextIndex")]
    public List<int?> ContextIndex { get; set; }

    [JsonPropertyName("expirationCondition")]
    public List<BattleCondition> ExpirationCondition { get; set; }

    [JsonPropertyName("applyType")]
    public EffectApplyType ApplyType { get; set; }

    [JsonPropertyName("damageType")]
    public EffectDamageType DamageType { get; set; }

    [JsonPropertyName("persistentIcon")]
    public string? PersistentIcon { get; set; }

    [JsonPropertyName("triggeredVfx")]
    public string? TriggeredVfx { get; set; }

    [JsonPropertyName("triggeredLocKey")]
    public string? TriggeredLocKey { get; set; }

    [JsonPropertyName("maxBonusMoves")]
    public int? MaxBonusMoves { get; set; }

    [JsonPropertyName("effectReference")]
    public List<EffectReference> EffectReference { get; set; }

    [JsonPropertyName("multiplierAmountDecimal")]
    public int? MultiplierAmountDecimal { get; set; }

    [JsonPropertyName("contextMultiplierDecimal")]
    public int? ContextMultiplierDecimal { get; set; }

    [JsonPropertyName("additiveAmountDecimal")]
    public long? AdditiveAmountDecimal { get; set; }

    [JsonPropertyName("resultVarianceDecimal")]
    public int? ResultVarianceDecimal { get; set; }

    [JsonPropertyName("persistentLocKey")]
    public string? PersistentLocKey { get; set; }

    [JsonPropertyName("stackingLineOverride")]
    public string? StackingLineOverride { get; set; }

    [JsonPropertyName("persistentIconOverlay")]
    public string? PersistentIconOverlay { get; set; }

    [JsonPropertyName("persistentIconPriority")]
    public int? PersistentIconPriority { get; set; }

    [JsonPropertyName("iconColor")]
    public string? IconColor { get; set; }

    [JsonPropertyName("persistentIconGroupable")]
    public bool? PersistentIconGroupable { get; set; }

    [JsonPropertyName("persistentVfxReference")]
    public PersistentVfxReference PersistentVfxReference { get; set; }

    [JsonPropertyName("blackboardName")]
    public string? BlackboardName { get; set; }

    [JsonPropertyName("summonId")]
    public string? SummonId { get; set; }

    [JsonPropertyName("summonEffect")]
    public List<Effect> SummonEffect { get; set; }

    [JsonPropertyName("summonLevel")]
    public int? SummonLevel { get; set; }

    [JsonPropertyName("summonTier")]
    public UnitTier SummonTier { get; set; }

    [JsonPropertyName("summonRarity")]
    public Rarity SummonRarity { get; set; }

    [JsonPropertyName("summonSquadIncrease")]
    public int? SummonSquadIncrease { get; set; }

    [JsonPropertyName("ignoreDamageAnimation")]
    public bool? IgnoreDamageAnimation { get; set; }

    [JsonPropertyName("infiniteCycleEffect")]
    public List<string?> InfiniteCycleEffect { get; set; }

    [JsonPropertyName("blackboardCompareName")]
    public string? BlackboardCompareName { get; set; }

    [JsonPropertyName("summonMarkerIndex")]
    public int? SummonMarkerIndex { get; set; }

    [JsonPropertyName("summonEnableInitialVfx")]
    public bool? SummonEnableInitialVfx { get; set; }

    [JsonPropertyName("summonCount")]
    public int? SummonCount { get; set; }

    [JsonPropertyName("triggerOnApplication")]
    public bool? TriggerOnApplication { get; set; }

    [JsonPropertyName("expireOnApplication")]
    public bool? ExpireOnApplication { get; set; }

    [JsonPropertyName("replaceTableId")]
    public string? ReplaceTableId { get; set; }

    [JsonPropertyName("applyEffectEnabled")]
    public bool? ApplyEffectEnabled { get; set; }

    [JsonPropertyName("applyEffectLabel")]
    public string? ApplyEffectLabel { get; set; }

    [JsonPropertyName("summonEraLevel")]
    public int? SummonEraLevel { get; set; }

}