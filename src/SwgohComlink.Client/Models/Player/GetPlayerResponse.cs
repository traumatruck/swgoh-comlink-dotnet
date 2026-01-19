using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Player;

public class GetPlayerResponse
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("level")]
    public int? Level { get; set; }

    [JsonPropertyName("allyCode")]
    public long? AllyCode { get; set; }

    [JsonPropertyName("playerId")]
    public string? PlayerId { get; set; }

    [JsonPropertyName("rosterUnit")]
    public List<Unit> RosterUnit { get; set; }

    [JsonPropertyName("profileStat")]
    public List<PlayerProfileStat> ProfileStat { get; set; }

    [JsonPropertyName("guildId")]
    public string? GuildId { get; set; }

    [JsonPropertyName("guildName")]
    public string? GuildName { get; set; }

    [JsonPropertyName("guildLogoBackground")]
    public string? GuildLogoBackground { get; set; }

    [JsonPropertyName("guildBannerColor")]
    public string? GuildBannerColor { get; set; }

    [JsonPropertyName("guildBannerLogo")]
    public string? GuildBannerLogo { get; set; }

    [JsonPropertyName("pvpProfile")]
    public List<PlayerPvpProfile> PvpProfile { get; set; }

    [JsonPropertyName("selectedPlayerTitle")]
    public PlayerTitle SelectedPlayerTitle { get; set; }

    [JsonPropertyName("unlockedPlayerTitle")]
    public List<PlayerTitle> UnlockedPlayerTitle { get; set; }

    [JsonPropertyName("guildTypeId")]
    public string? GuildTypeId { get; set; }

    [JsonPropertyName("localTimeZoneOffsetMinutes")]
    public int? LocalTimeZoneOffsetMinutes { get; set; }

    [JsonPropertyName("lastActivityTime")]
    public long? LastActivityTime { get; set; }

    [JsonPropertyName("selectedPlayerPortrait")]
    public PlayerPortrait SelectedPlayerPortrait { get; set; }

    [JsonPropertyName("unlockedPlayerPortrait")]
    public List<PlayerPortrait> UnlockedPlayerPortrait { get; set; }

    [JsonPropertyName("seasonStatus")]
    public List<SeasonStatus> SeasonStatus { get; set; }

    [JsonPropertyName("lifetimeSeasonScore")]
    public long? LifetimeSeasonScore { get; set; }

    [JsonPropertyName("playerRating")]
    public PlayerRating PlayerRating { get; set; }

    [JsonPropertyName("datacron")]
    public List<Datacron> Datacron { get; set; }

    [JsonPropertyName("nucleusId")]
    public string? NucleusId { get; set; }

    [JsonPropertyName("eraUnitStatus")]
    public List<EraUnitStatus> EraUnitStatus { get; set; }

}