using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class WarNodeDef
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public WarNodeType Type { get; set; }

    [JsonPropertyName("combatType")]
    public CombatType CombatType { get; set; }

    [JsonPropertyName("position")]
    public Position Position { get; set; }

}