using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class BattleCondition
{
    [JsonPropertyName("conditionType")]
    public ConditionType ConditionType { get; set; }

    [JsonPropertyName("conditionValue")]
    public string? ConditionValue { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }
}