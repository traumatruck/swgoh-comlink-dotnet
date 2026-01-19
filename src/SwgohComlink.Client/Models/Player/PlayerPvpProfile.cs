using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Player;

public class PlayerPvpProfile
{
    [JsonPropertyName("tab")]
    public PlayerProfileTab Tab { get; set; }

    [JsonPropertyName("rank")]
    public int? Rank { get; set; }

    [JsonPropertyName("squad")]
    public Squad Squad { get; set; }

    [JsonPropertyName("eventId")]
    public string? EventId { get; set; }
}