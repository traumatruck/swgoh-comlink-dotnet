using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class GuildMember
{
    [JsonPropertyName("playerId")]
    public string? PlayerId { get; set; }

    [JsonPropertyName("playerName")]
    public string? PlayerName { get; set; }

    [JsonPropertyName("playerLevel")]
    public int? PlayerLevel { get; set; }

    [JsonPropertyName("memberLevel")]
    public GuildMemberLevel MemberLevel { get; set; }

    [JsonPropertyName("guildXp")]
    public int? GuildXp { get; set; }

    [JsonPropertyName("lastActivityTime")]
    public long? LastActivityTime { get; set; }

    [JsonPropertyName("squadPower")]
    public int? SquadPower { get; set; }

    [JsonPropertyName("memberContribution")]
    public List<GuildMemberContribution> MemberContribution { get; set; }

    [JsonPropertyName("guildJoinTime")]
    public long? GuildJoinTime { get; set; }

    [JsonPropertyName("galacticPower")]
    public long? GalacticPower { get; set; }

    [JsonPropertyName("playerTitle")]
    public string? PlayerTitle { get; set; }

    [JsonPropertyName("playerPortrait")]
    public string? PlayerPortrait { get; set; }

    [JsonPropertyName("seasonStatus")]
    public List<SeasonStatus> SeasonStatus { get; set; }

    [JsonPropertyName("lifetimeSeasonScore")]
    public long? LifetimeSeasonScore { get; set; }

    [JsonPropertyName("leagueId")]
    public string? LeagueId { get; set; }

    [JsonPropertyName("shipGalacticPower")]
    public long? ShipGalacticPower { get; set; }

    [JsonPropertyName("characterGalacticPower")]
    public long? CharacterGalacticPower { get; set; }

    [JsonPropertyName("nucleusId")]
    public string? NucleusId { get; set; }

}