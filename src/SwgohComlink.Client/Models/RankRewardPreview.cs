using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class RankRewardPreview
{
    [JsonPropertyName("rankStart")]
    public int? RankStart { get; set; }

    [JsonPropertyName("rankEnd")]
    public int? RankEnd { get; set; }

    [JsonPropertyName("primaryReward")]
    public List<BucketItem> PrimaryReward { get; set; }

    [JsonPropertyName("detailedReward")]
    public List<BucketItem> DetailedReward { get; set; }
}