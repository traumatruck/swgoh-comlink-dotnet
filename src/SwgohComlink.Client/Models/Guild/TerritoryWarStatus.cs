using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryWarStatus
{
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    [JsonPropertyName("definitionId")]
    public string? DefinitionId { get; set; }

    [JsonPropertyName("currentRound")]
    public int? CurrentRound { get; set; }

    [JsonPropertyName("currentRoundEndTime")]
    public long? CurrentRoundEndTime { get; set; }

    [JsonPropertyName("channelId")]
    public string? ChannelId { get; set; }

    [JsonPropertyName("homeGuild")]
    public TerritoryWarGuildStatus HomeGuild { get; set; }

    [JsonPropertyName("awayGuild")]
    public TerritoryWarGuildStatus AwayGuild { get; set; }

    [JsonPropertyName("playerStatus")]
    public TerritoryWarPlayerStatus PlayerStatus { get; set; }

    [JsonPropertyName("currentStat")]
    public List<TerritoryMapStat> CurrentStat { get; set; }

    [JsonPropertyName("optedInMemberId")]
    public List<string?> OptedInMemberId { get; set; }

    [JsonPropertyName("optedInMember")]
    public List<TerritoryWarParticipant> OptedInMember { get; set; }

    [JsonPropertyName("excludedFromWar")]
    public bool? ExcludedFromWar { get; set; }

    [JsonPropertyName("hasReportedEnemyGuild")]
    public bool? HasReportedEnemyGuild { get; set; }

    [JsonPropertyName("lastCommandNotificationTime")]
    public long? LastCommandNotificationTime { get; set; }

    [JsonPropertyName("mapCompletedEarly")]
    public bool? MapCompletedEarly { get; set; }

}