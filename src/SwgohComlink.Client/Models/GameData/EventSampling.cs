using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class EventSampling
{
    [JsonPropertyName("eventId")]
    public string? EventId { get; set; }

    [JsonPropertyName("spenderValue")]
    public int? SpenderValue { get; set; }

    [JsonPropertyName("nonSpenderValue")]
    public int? NonSpenderValue { get; set; }
}