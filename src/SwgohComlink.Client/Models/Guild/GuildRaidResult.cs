using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class GuildRaidResult
{
    [JsonPropertyName("raidId")]
    public string? RaidId { get; set; }

    [JsonPropertyName("identifier")]
    public CampaignElementIdentifier Identifier { get; set; }

    [JsonPropertyName("duration")]
    public long? Duration { get; set; }

    [JsonPropertyName("progress")]
    public double? Progress { get; set; }

    [JsonPropertyName("raidMember")]
    public List<RaidMember> RaidMember { get; set; }

    [JsonPropertyName("endTime")]
    public long? EndTime { get; set; }

    [JsonPropertyName("outcome")]
    public RaidOutcome Outcome { get; set; }

    [JsonPropertyName("encounterProgress")]
    public List<long?> EncounterProgress { get; set; }

    [JsonPropertyName("guildRewardScore")]
    public long? GuildRewardScore { get; set; }

    [JsonPropertyName("cachedRewards")]
    public CachedRaidRewards CachedRewards { get; set; }
}