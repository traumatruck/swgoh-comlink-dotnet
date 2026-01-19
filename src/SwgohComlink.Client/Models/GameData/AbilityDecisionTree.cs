using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class AbilityDecisionTree
{
    [JsonPropertyName("abilityDecisionTreeId")]
    public string? AbilityDecisionTreeId { get; set; }

    [JsonPropertyName("abilityDecisionNode")]
    public List<AbilityDecisionNode> AbilityDecisionNode { get; set; }

}