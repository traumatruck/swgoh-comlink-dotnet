using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class UnlockAnnouncementDefinition
{
    [JsonPropertyName("feature")]
    public string? Feature { get; set; }

    [JsonPropertyName("startOffset")]
    public int? StartOffset { get; set; }

    [JsonPropertyName("interval")]
    public int? Interval { get; set; }

    [JsonPropertyName("messageKey")]
    public string? MessageKey { get; set; }
}