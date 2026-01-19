using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class AbilityTier
{
    [JsonPropertyName("descKey")]
    public string? DescKey { get; set; }

    [JsonPropertyName("upgradeDescKey")]
    public string? UpgradeDescKey { get; set; }

    [JsonPropertyName("cooldownMaxOverride")]
    public int? CooldownMaxOverride { get; set; }

    [JsonPropertyName("effectReference")]
    public List<EffectReference> EffectReference { get; set; }

    [JsonPropertyName("interactsWithTag")]
    public List<EffectTag> InteractsWithTag { get; set; }

    [JsonPropertyName("blockingEffectId")]
    public string? BlockingEffectId { get; set; }

    [JsonPropertyName("blockedLocKey")]
    public string? BlockedLocKey { get; set; }

}