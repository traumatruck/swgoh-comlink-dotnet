using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class RoomData
{
    [JsonPropertyName("roomId")]
    public string? RoomId { get; set; }

    [JsonPropertyName("type")]
    public RoomType Type { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("topic")]
    public string? Topic { get; set; }

    [JsonPropertyName("creationTime")]
    public long? CreationTime { get; set; }

    [JsonPropertyName("ownerId")]
    public string? OwnerId { get; set; }
}