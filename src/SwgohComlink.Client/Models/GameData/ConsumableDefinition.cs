using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ConsumableDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("tierId")]
    public string? TierId { get; set; }

    [JsonPropertyName("iconKey")]
    public string? IconKey { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("descriptionKey")]
    public string? DescriptionKey { get; set; }

    [JsonPropertyName("totalBattleUse")]
    public int? TotalBattleUse { get; set; }

    [JsonPropertyName("grantedAbility")]
    public List<MissionGrantedAbility> GrantedAbility { get; set; }

    [JsonPropertyName("staminaRecovery")]
    public int? StaminaRecovery { get; set; }

    [JsonPropertyName("targetedStat")]
    public List<TargetedStat> TargetedStat { get; set; }

    [JsonPropertyName("consumableTypeId")]
    public string? ConsumableTypeId { get; set; }

    [JsonPropertyName("effectIconKey")]
    public string? EffectIconKey { get; set; }

    [JsonPropertyName("activeTimeInSeconds")]
    public long? ActiveTimeInSeconds { get; set; }

    [JsonPropertyName("staminaRegenTimeReduction")]
    public int? StaminaRegenTimeReduction { get; set; }

    [JsonPropertyName("energyRegenTimeReduction")]
    public int? EnergyRegenTimeReduction { get; set; }
}