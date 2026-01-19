using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class Ability
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("descKey")]
    public string? DescKey { get; set; }

    [JsonPropertyName("prefabName")]
    public string? PrefabName { get; set; }

    [JsonPropertyName("triggerCondition")]
    public List<BattleCondition> TriggerCondition { get; set; }

    [JsonPropertyName("stackingLineOverride")]
    public string? StackingLineOverride { get; set; }

    [JsonPropertyName("tier")]
    public List<AbilityTier> Tier { get; set; }

    [JsonPropertyName("cooldown")]
    public int? Cooldown { get; set; }

    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    [JsonPropertyName("applyTypeTooltipKey")]
    public string? ApplyTypeTooltipKey { get; set; }

    [JsonPropertyName("descriptiveTag")]
    public List<EffectTag> DescriptiveTag { get; set; }

    [JsonPropertyName("effectReference")]
    public List<EffectReference> EffectReference { get; set; }

    [JsonPropertyName("confirmationMessage")]
    public MessageDialog ConfirmationMessage { get; set; }

    [JsonPropertyName("buttonLocation")]
    public AbilityButtonLocationType ButtonLocation { get; set; }

    [JsonPropertyName("shortDescKey")]
    public string? ShortDescKey { get; set; }

    [JsonPropertyName("abilityType")]
    public AbilityType AbilityType { get; set; }

    [JsonPropertyName("detailLocation")]
    public UnitDetailsAbilityLocation DetailLocation { get; set; }

    [JsonPropertyName("allyTargetingRuleId")]
    public string? AllyTargetingRuleId { get; set; }

    [JsonPropertyName("useAsReinforcementDesc")]
    public bool? UseAsReinforcementDesc { get; set; }

    [JsonPropertyName("interactsWithTag")]
    public List<EffectTag> InteractsWithTag { get; set; }

    [JsonPropertyName("subIcon")]
    public string? SubIcon { get; set; }

    [JsonPropertyName("aiParams")]
    public AbilityAIParams AiParams { get; set; }

    [JsonPropertyName("cooldownType")]
    public AbilityCooldownType CooldownType { get; set; }

    [JsonPropertyName("alwaysDisplayInBattleUi")]
    public bool? AlwaysDisplayInBattleUi { get; set; }

    [JsonPropertyName("highlightWhenReadyInBattleUi")]
    public bool? HighlightWhenReadyInBattleUi { get; set; }

    [JsonPropertyName("hideCooldownDescription")]
    public bool? HideCooldownDescription { get; set; }

    [JsonPropertyName("blockingEffectId")]
    public string? BlockingEffectId { get; set; }

    [JsonPropertyName("blockedLocKey")]
    public string? BlockedLocKey { get; set; }

    [JsonPropertyName("ultimateChargeRequired")]
    public List<int?> UltimateChargeRequired { get; set; }

    [JsonPropertyName("grantedPriority")]
    public int? GrantedPriority { get; set; }

    [JsonPropertyName("synergy")]
    public AbilitySynergy Synergy { get; set; }

    [JsonPropertyName("visualTarget")]
    public EffectTarget VisualTarget { get; set; }
}