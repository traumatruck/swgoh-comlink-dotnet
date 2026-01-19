using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryBattleStatus
{
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    [JsonPropertyName("definitionId")]
    public string? DefinitionId { get; set; }

    [JsonPropertyName("conflictZoneStatus")]
    public List<TerritoryConflictZoneStatus> ConflictZoneStatus { get; set; }

    [JsonPropertyName("strikeZoneStatus")]
    public List<TerritoryStrikeZoneStatus> StrikeZoneStatus { get; set; }

    [JsonPropertyName("reconZoneStatus")]
    public List<TerritoryReconZoneStatus> ReconZoneStatus { get; set; }

    [JsonPropertyName("playerStatus")]
    public TerritoryBattlePlayerStatus PlayerStatus { get; set; }

    [JsonPropertyName("currentRound")]
    public int? CurrentRound { get; set; }

    [JsonPropertyName("currentRoundEndTime")]
    public long? CurrentRoundEndTime { get; set; }

    [JsonPropertyName("channelId")]
    public string? ChannelId { get; set; }

    [JsonPropertyName("covertZoneStatus")]
    public List<TerritoryCovertZoneStatus> CovertZoneStatus { get; set; }

    [JsonPropertyName("currentStat")]
    public List<TerritoryMapStat> CurrentStat { get; set; }

    [JsonPropertyName("lastCommandNotificationTime")]
    public long? LastCommandNotificationTime { get; set; }

    [JsonPropertyName("mapCompletedEarly")]
    public bool? MapCompletedEarly { get; set; }

    [JsonPropertyName("selected")]
    public bool? Selected { get; set; }

}