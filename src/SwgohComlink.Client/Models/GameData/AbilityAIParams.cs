using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class AbilityAIParams
{
    [JsonPropertyName("preferredAllyTargetingRuleId")]
    public string? PreferredAllyTargetingRuleId { get; set; }

    [JsonPropertyName("preferredEnemyTargetingRuleId")]
    public string? PreferredEnemyTargetingRuleId { get; set; }

    [JsonPropertyName("requireEnemyPreferredTargets")]
    public bool? RequireEnemyPreferredTargets { get; set; }

    [JsonPropertyName("requireAllyTargets")]
    public bool? RequireAllyTargets { get; set; }

    [JsonPropertyName("preferredAllyTargetingRuleIdList")]
    public List<string?> PreferredAllyTargetingRuleIdList { get; set; }

    [JsonPropertyName("preferredEnemyTargetingRuleIdList")]
    public List<string?> PreferredEnemyTargetingRuleIdList { get; set; }
}