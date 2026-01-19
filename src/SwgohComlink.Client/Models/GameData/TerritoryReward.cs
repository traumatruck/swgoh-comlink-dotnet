using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TerritoryReward
{
    [JsonPropertyName("type")]
    public TerritoryRewardType Type { get; set; }

    [JsonPropertyName("value")]
    public long? Value { get; set; }

    [JsonPropertyName("rewardId")]
    public string? RewardId { get; set; }

}