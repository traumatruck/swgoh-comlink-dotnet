using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class BattleUnitState
{
    [JsonPropertyName("unitId")]
    public string? UnitId { get; set; }

    [JsonPropertyName("healthPercent")]
    public string? HealthPercent { get; set; }

    [JsonPropertyName("abilityState")]
    public List<BattleUnitAbilityState> AbilityState { get; set; }

    [JsonPropertyName("progressItem")]
    public bool? ProgressItem { get; set; }

    [JsonPropertyName("currentHealth")]
    public long? CurrentHealth { get; set; }

    [JsonPropertyName("shieldPercent")]
    public string? ShieldPercent { get; set; }

    [JsonPropertyName("turnPercent")]
    public string? TurnPercent { get; set; }

    [JsonPropertyName("maxHealth")]
    public long? MaxHealth { get; set; }

    [JsonPropertyName("hasFled")]
    public bool? HasFled { get; set; }

    [JsonPropertyName("maxShield")]
    public long? MaxShield { get; set; }

    [JsonPropertyName("isCommander")]
    public bool? IsCommander { get; set; }

    [JsonPropertyName("isDeployed")]
    public bool? IsDeployed { get; set; }

    [JsonPropertyName("currentShield")]
    public long? CurrentShield { get; set; }

    [JsonPropertyName("overkillItem")]
    public bool? OverkillItem { get; set; }

    [JsonPropertyName("overkillDamage")]
    public long? OverkillDamage { get; set; }

    [JsonPropertyName("battleContextMaxShield")]
    public long? BattleContextMaxShield { get; set; }

    [JsonPropertyName("isUnscathed")]
    public bool? IsUnscathed { get; set; }
}