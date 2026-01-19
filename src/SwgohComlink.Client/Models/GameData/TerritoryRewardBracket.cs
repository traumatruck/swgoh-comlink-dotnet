using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TerritoryRewardBracket
{
    [JsonPropertyName("victoryPointReward")]
    public int? VictoryPointReward { get; set; }

    [JsonPropertyName("galacticScoreRequirement")]
    public long? GalacticScoreRequirement { get; set; }

    [JsonPropertyName("reward")]
    public TerritoryReward Reward { get; set; }
}