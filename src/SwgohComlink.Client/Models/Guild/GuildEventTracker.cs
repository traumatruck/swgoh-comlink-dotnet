using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class GuildEventTracker
{
    [JsonPropertyName("definitionId")]
    public string? DefinitionId { get; set; }

    [JsonPropertyName("completedStars")]
    public long? CompletedStars { get; set; }

    [JsonPropertyName("endTime")]
    public long? EndTime { get; set; }
}