using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class SeasonDivisionSkillBoundary
{
    [JsonPropertyName("leagueId")]
    public string? LeagueId { get; set; }

    [JsonPropertyName("divisionId")]
    public int? DivisionId { get; set; }

    [JsonPropertyName("minSkill")]
    public int? MinSkill { get; set; }
}