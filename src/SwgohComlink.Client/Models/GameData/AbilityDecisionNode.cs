using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class AbilityDecisionNode
{
    [JsonPropertyName("decisionType")]
    public AbilityDecisionType DecisionType { get; set; }

    [JsonPropertyName("decisionTarget")]
    public AbilityDecisionTarget DecisionTarget { get; set; }

    [JsonPropertyName("param")]
    public List<string?> Param { get; set; }

    [JsonPropertyName("paramModifier")]
    public AbilityDecisionParamModifier ParamModifier { get; set; }

    [JsonPropertyName("targetExcludeSelf")]
    public bool? TargetExcludeSelf { get; set; }

    [JsonPropertyName("chance")]
    public long? Chance { get; set; }

    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    [JsonPropertyName("decisionResult")]
    public AbilityDecisionResult DecisionResult { get; set; }
}