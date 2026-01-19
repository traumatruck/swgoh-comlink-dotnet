using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Events;

public class GetEventsResponse
{
    [JsonPropertyName("gameEvent")]
    public List<GameEvent> GameEvent { get; set; }
}