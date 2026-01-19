using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class GuildProfile
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("externalMessageKey")]
    public string? ExternalMessageKey { get; set; }

    [JsonPropertyName("messageCriteriaKey")]
    public List<string?> MessageCriteriaKey { get; set; }

    [JsonPropertyName("logoBackground")]
    public string? LogoBackground { get; set; }

    [JsonPropertyName("enrollmentStatus")]
    public EnrollmentStatus EnrollmentStatus { get; set; }

    [JsonPropertyName("trophy")]
    public int? Trophy { get; set; }

    [JsonPropertyName("memberCount")]
    public int? MemberCount { get; set; }

    [JsonPropertyName("memberMax")]
    public int? MemberMax { get; set; }

    [JsonPropertyName("level")]
    public int? Level { get; set; }

    [JsonPropertyName("rank")]
    public int? Rank { get; set; }

    [JsonPropertyName("levelRequirement")]
    public int? LevelRequirement { get; set; }

    [JsonPropertyName("raidWin")]
    public int? RaidWin { get; set; }

    [JsonPropertyName("leaderboardScore")]
    public long? LeaderboardScore { get; set; }

    [JsonPropertyName("bannerColorId")]
    public string? BannerColorId { get; set; }

    [JsonPropertyName("bannerLogoId")]
    public string? BannerLogoId { get; set; }

    [JsonPropertyName("guildGalacticPower")]
    public long? GuildGalacticPower { get; set; }

    [JsonPropertyName("chatChannelId")]
    public string? ChatChannelId { get; set; }

    [JsonPropertyName("guildType")]
    public string? GuildType { get; set; }

    [JsonPropertyName("raidLaunchConfig")]
    public List<GuildRaidLaunchConfig> RaidLaunchConfig { get; set; }

    [JsonPropertyName("guildEventTracker")]
    public List<GuildEventTracker> GuildEventTracker { get; set; }

    [JsonPropertyName("guildGalacticPowerForRequirement")]
    public long? GuildGalacticPowerForRequirement { get; set; }

    [JsonPropertyName("singleLaunchConfig")]
    public GuildRaidLaunchConfig SingleLaunchConfig { get; set; }

    [JsonPropertyName("autoLaunchConfig")]
    public GuildRaidLaunchConfig AutoLaunchConfig { get; set; }

}