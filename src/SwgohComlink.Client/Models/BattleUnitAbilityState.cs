using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class BattleUnitAbilityState
{
    [JsonPropertyName("abilityId")]
    public string? AbilityId { get; set; }

    [JsonPropertyName("cooldown")]
    public int? Cooldown { get; set; }

}