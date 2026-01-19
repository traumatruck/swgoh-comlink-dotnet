using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class RaidAbilityOverride
{
    [JsonPropertyName("abilityId")]
    public string? AbilityId { get; set; }

    [JsonPropertyName("targetRuleId")]
    public string? TargetRuleId { get; set; }

    [JsonPropertyName("locKey")]
    public string? LocKey { get; set; }

    [JsonPropertyName("icon")]
    public string? Icon { get; set; }
}