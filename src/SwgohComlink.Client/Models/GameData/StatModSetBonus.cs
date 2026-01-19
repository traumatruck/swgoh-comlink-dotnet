using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class StatModSetBonus
{
    [JsonPropertyName("abilityId")]
    public List<string?> AbilityId { get; set; }

    [JsonPropertyName("stat")]
    public Stat Stat { get; set; }
}