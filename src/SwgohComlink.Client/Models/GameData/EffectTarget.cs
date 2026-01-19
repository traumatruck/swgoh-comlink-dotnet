using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class EffectTarget
{
    [JsonPropertyName("unitSelect")]
    public EffectTargetUnitSelect UnitSelect { get; set; }

    [JsonPropertyName("battleSide")]
    public EffectTargetBattleSide BattleSide { get; set; }

    [JsonPropertyName("unitClass")]
    public List<UnitClass> UnitClass { get; set; }

    [JsonPropertyName("forceAlignment")]
    public List<ForceAlignment> ForceAlignment { get; set; }

    [JsonPropertyName("category")]
    public EffectTargetCategoryCriteria Category { get; set; }

    [JsonPropertyName("healthState")]
    public UnitHealthState HealthState { get; set; }

    [JsonPropertyName("statValue")]
    public List<StatValueRange> StatValue { get; set; }

    [JsonPropertyName("activeEffectTagCriteria")]
    public List<EffectTagCriteria> ActiveEffectTagCriteria { get; set; }

    [JsonPropertyName("battleDeploymentState")]
    public BattleDeploymentState BattleDeploymentState { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("excludeSelf")]
    public bool? ExcludeSelf { get; set; }

    [JsonPropertyName("excludeSelectedTarget")]
    public bool? ExcludeSelectedTarget { get; set; }

    [JsonPropertyName("requiredCategory")]
    public EffectTargetCategoryCriteria RequiredCategory { get; set; }

    [JsonPropertyName("requiredActiveEffectTagCriteria")]
    public List<EffectTagCriteria> RequiredActiveEffectTagCriteria { get; set; }
}