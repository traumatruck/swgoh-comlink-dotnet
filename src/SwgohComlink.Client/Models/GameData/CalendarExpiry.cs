using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class CalendarExpiry
{
    [JsonPropertyName("duration")]
    public long? Duration { get; set; }

    [JsonPropertyName("endTime")]
    public long? EndTime { get; set; }

    [JsonPropertyName("expiryRequirement")]
    public Requirement ExpiryRequirement { get; set; }
}