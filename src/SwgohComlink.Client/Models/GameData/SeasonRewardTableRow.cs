using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class SeasonRewardTableRow
{
    [JsonPropertyName("key")]
    public SeasonRewardTableKey Key { get; set; }

    [JsonPropertyName("primaryReward")]
    public List<BucketItem> PrimaryReward { get; set; }

    [JsonPropertyName("detailedReward")]
    public List<BucketItem> DetailedReward { get; set; }
}