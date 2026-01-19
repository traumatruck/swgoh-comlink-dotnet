using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class EnvironmentCollection
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("battleEnvironment")]
    public List<Environment> BattleEnvironment { get; set; }
}