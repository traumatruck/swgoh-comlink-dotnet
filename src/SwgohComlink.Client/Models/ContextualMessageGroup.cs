using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class ContextualMessageGroup
{
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    [JsonPropertyName("startMessage")]
    public string? StartMessage { get; set; }

    [JsonPropertyName("message")]
    public List<ContextualMessage> Message { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("canDismissWhileHidden")]
    public bool? CanDismissWhileHidden { get; set; }

    [JsonPropertyName("startTime")]
    public long? StartTime { get; set; }

    [JsonPropertyName("endTime")]
    public long? EndTime { get; set; }

    [JsonPropertyName("isFtue")]
    public bool? IsFtue { get; set; }
}