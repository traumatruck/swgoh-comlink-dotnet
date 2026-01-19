using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class SeasonLeagueReference
{
    [JsonPropertyName("definitionId")]
    public string? DefinitionId { get; set; }

    [JsonPropertyName("promoteSystem")]
    public SeasonLeaguePromoteSystem PromoteSystem { get; set; }

    [JsonPropertyName("promoteCondition")]
    public int? PromoteCondition { get; set; }

    [JsonPropertyName("rewardPreview")]
    public List<LeagueDivisionRewardPreview> RewardPreview { get; set; }

    [JsonPropertyName("promoteConditionTable")]
    public string? PromoteConditionTable { get; set; }

}