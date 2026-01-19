using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ConditionalBucket
{
    [JsonPropertyName("requirementId")]
    public string? RequirementId { get; set; }

    [JsonPropertyName("bucketItem")]
    public List<BucketItem> BucketItem { get; set; }
}