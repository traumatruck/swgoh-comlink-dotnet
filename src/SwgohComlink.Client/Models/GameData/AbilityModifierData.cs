using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class AbilityModifierData
{
    [JsonPropertyName("battleSide")]
    public EffectTargetBattleSide BattleSide { get; set; }

    [JsonPropertyName("tint")]
    public string? Tint { get; set; }

    [JsonPropertyName("tierKey")]
    public string? TierKey { get; set; }

    [JsonPropertyName("icon")]
    public string? Icon { get; set; }
}