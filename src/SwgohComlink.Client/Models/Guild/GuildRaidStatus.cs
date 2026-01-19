using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class GuildRaidStatus
{
    [JsonPropertyName("raidId")]
    public string? RaidId { get; set; }

    [JsonPropertyName("expireTime")]
    public long? ExpireTime { get; set; }

    [JsonPropertyName("raidProgress")]
    public double? RaidProgress { get; set; }

    [JsonPropertyName("raidMemberOld")]
    public List<GuildRaidMember> RaidMemberOld { get; set; }

    [JsonPropertyName("opponentUnitState")]
    public List<BattleUnitState> OpponentUnitState { get; set; }

    [JsonPropertyName("playerUnitState")]
    public List<BattleUnitState> PlayerUnitState { get; set; }

    [JsonPropertyName("identifier")]
    public CampaignElementIdentifier Identifier { get; set; }

    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    [JsonPropertyName("rosterRefreshTime")]
    public long? RosterRefreshTime { get; set; }

    [JsonPropertyName("hasPlayerParticipated")]
    public bool? HasPlayerParticipated { get; set; }

    [JsonPropertyName("raidState")]
    public RaidState RaidState { get; set; }

    [JsonPropertyName("tallyEndTime")]
    public long? TallyEndTime { get; set; }

    [JsonPropertyName("eligibleForRewards")]
    public bool? EligibleForRewards { get; set; }

    [JsonPropertyName("activateTimeMs")]
    public long? ActivateTimeMs { get; set; }

    [JsonPropertyName("forbidLateEntry")]
    public bool? ForbidLateEntry { get; set; }

    [JsonPropertyName("joinPeriodEndTimeMs")]
    public long? JoinPeriodEndTimeMs { get; set; }

    [JsonPropertyName("raidMember")]
    public List<RaidMember> RaidMember { get; set; }

    [JsonPropertyName("simEnabled")]
    public bool? SimEnabled { get; set; }

    [JsonPropertyName("encounterId")]
    public string? EncounterId { get; set; }

    [JsonPropertyName("lastEncounterIdPlayerParticipated")]
    public string? LastEncounterIdPlayerParticipated { get; set; }

    [JsonPropertyName("currentEncounterPointsScored")]
    public int? CurrentEncounterPointsScored { get; set; }

    [JsonPropertyName("guildRewardScore")]
    public long? GuildRewardScore { get; set; }

    [JsonPropertyName("ineligibleMemberId")]
    public List<string?> IneligibleMemberId { get; set; }

    [JsonPropertyName("claimedImmediateRewards")]
    public List<int?> ClaimedImmediateRewards { get; set; }

    [JsonPropertyName("cachedRewards")]
    public CachedRaidRewards CachedRewards { get; set; }

    [JsonPropertyName("exhaustedDatacronId")]
    public List<string?> ExhaustedDatacronId { get; set; }

}