using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Gac;

public class LeaderboardPlayer
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("level")]
    public int? Level { get; set; }

    [JsonPropertyName("guild")]
    public LeaderboardGuild Guild { get; set; }

    [JsonPropertyName("isFake")]
    public bool? IsFake { get; set; }

    [JsonPropertyName("pvpStatus")]
    public LeaderboardStatus PvpStatus { get; set; }

    [JsonPropertyName("squadUnit")]
    public List<Unit> SquadUnit { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("power")]
    public int? Power { get; set; }

    [JsonPropertyName("portrait")]
    public string? Portrait { get; set; }

    [JsonPropertyName("seasonsLifetimeScore")]
    public long? SeasonsLifetimeScore { get; set; }

    [JsonPropertyName("seasonLeagueId")]
    public string? SeasonLeagueId { get; set; }

    [JsonPropertyName("playerRating")]
    public PlayerRating PlayerRating { get; set; }

    [JsonPropertyName("tier")]
    public int? Tier { get; set; }

}