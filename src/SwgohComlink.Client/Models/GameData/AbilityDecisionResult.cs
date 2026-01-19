using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class AbilityDecisionResult
{
    [JsonPropertyName("chosenAbilityTag")]
    public string? ChosenAbilityTag { get; set; }

    [JsonPropertyName("decisionResultTarget")]
    public AbilityDecisionResultTarget DecisionResultTarget { get; set; }

    [JsonPropertyName("allyTargetId")]
    public List<string?> AllyTargetId { get; set; }

}