using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ForcedPlayerSquad
{
    [JsonPropertyName("squad")]
    public Squad Squad { get; set; }

    [JsonPropertyName("squadUnit")]
    public List<Unit> SquadUnit { get; set; }
}