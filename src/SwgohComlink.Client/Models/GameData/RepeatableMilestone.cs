using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class RepeatableMilestone
{
    [JsonPropertyName("pointInterval")]
    public int? PointInterval { get; set; }

    [JsonPropertyName("reward")]
    public BucketItem Reward { get; set; }

}