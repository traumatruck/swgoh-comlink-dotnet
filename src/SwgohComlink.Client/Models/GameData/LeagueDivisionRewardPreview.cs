using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class LeagueDivisionRewardPreview
{
    [JsonPropertyName("division")]
    public int? Division { get; set; }

    [JsonPropertyName("primaryReward")]
    public List<BucketItem> PrimaryReward { get; set; }

    [JsonPropertyName("detailedReward")]
    public List<BucketItem> DetailedReward { get; set; }
}