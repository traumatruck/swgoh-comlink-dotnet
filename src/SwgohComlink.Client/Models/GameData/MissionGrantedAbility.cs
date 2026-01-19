using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class MissionGrantedAbility
{
    [JsonPropertyName("abilityId")]
    public string? AbilityId { get; set; }

    [JsonPropertyName("targetRuleId")]
    public string? TargetRuleId { get; set; }

    [JsonPropertyName("unlockRequirement")]
    public Requirement UnlockRequirement { get; set; }

    [JsonPropertyName("rankLabelOverrideKey")]
    public string? RankLabelOverrideKey { get; set; }

    [JsonPropertyName("useOverlayIcon")]
    public bool? UseOverlayIcon { get; set; }

    [JsonPropertyName("overlaySpriteName")]
    public string? OverlaySpriteName { get; set; }

    [JsonPropertyName("zonesToApplyTo")]
    public List<string?> ZonesToApplyTo { get; set; }

    [JsonPropertyName("showInPlatoonView")]
    public bool? ShowInPlatoonView { get; set; }

    [JsonPropertyName("modifierData")]
    public AbilityModifierData ModifierData { get; set; }

    [JsonPropertyName("conditionDescKey")]
    public string? ConditionDescKey { get; set; }
}