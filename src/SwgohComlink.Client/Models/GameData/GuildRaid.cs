using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class GuildRaid
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("summaryKey")]
    public string? SummaryKey { get; set; }

    [JsonPropertyName("descKey")]
    public string? DescKey { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("squadType")]
    public SquadType SquadType { get; set; }

    [JsonPropertyName("campaignElementIdentifier")]
    public CampaignElementIdentifier CampaignElementIdentifier { get; set; }

    [JsonPropertyName("iconPrefab")]
    public string? IconPrefab { get; set; }

    [JsonPropertyName("promotionKey")]
    public string? PromotionKey { get; set; }

    [JsonPropertyName("portraitIcon")]
    public string? PortraitIcon { get; set; }

    [JsonPropertyName("raidSim")]
    public GuildRaidSim RaidSim { get; set; }

    [JsonPropertyName("infoImage")]
    public string? InfoImage { get; set; }

    [JsonPropertyName("lockout")]
    public GuildRaidLockout Lockout { get; set; }

    [JsonPropertyName("legacyRaid")]
    public bool? LegacyRaid { get; set; }

    [JsonPropertyName("currencyReward")]
    public List<string?> CurrencyReward { get; set; }

    [JsonPropertyName("guildRewardsRequireAttempt")]
    public bool? GuildRewardsRequireAttempt { get; set; }

    [JsonPropertyName("audioVictoryKey")]
    public string? AudioVictoryKey { get; set; }

    [JsonPropertyName("audioDefeatKey")]
    public string? AudioDefeatKey { get; set; }

}