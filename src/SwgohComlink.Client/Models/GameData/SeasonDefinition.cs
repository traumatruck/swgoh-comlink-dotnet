using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class SeasonDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("seasonLeagueReference")]
    public List<SeasonLeagueReference> SeasonLeagueReference { get; set; }

    [JsonPropertyName("seasonDivisionReference")]
    public List<SeasonDivisionReference> SeasonDivisionReference { get; set; }

    [JsonPropertyName("seasonRewardTableId")]
    public string? SeasonRewardTableId { get; set; }

    [JsonPropertyName("minimumBannerSeasonRewardThreshold")]
    public int? MinimumBannerSeasonRewardThreshold { get; set; }

    [JsonPropertyName("divisionSkillBoundary")]
    public List<SeasonDivisionSkillBoundary> DivisionSkillBoundary { get; set; }

}