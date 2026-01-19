using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class GuildRaidLaunchConfig
{
    [JsonPropertyName("raidId")]
    public string? RaidId { get; set; }

    [JsonPropertyName("campaignMissionIdentifier")]
    public CampaignElementIdentifier CampaignMissionIdentifier { get; set; }

    [JsonPropertyName("autoLaunch")]
    public bool? AutoLaunch { get; set; }

    [JsonPropertyName("autoLaunchImmediately")]
    public bool? AutoLaunchImmediately { get; set; }

    [JsonPropertyName("autoLaunchTime")]
    public long? AutoLaunchTime { get; set; }

    [JsonPropertyName("joinPeriodDuration")]
    public long? JoinPeriodDuration { get; set; }

    [JsonPropertyName("autoSimEnabled")]
    public bool? AutoSimEnabled { get; set; }

    [JsonPropertyName("immediate")]
    public bool? Immediate { get; set; }

    [JsonPropertyName("scheduledUtcOffsetSeconds")]
    public long? ScheduledUtcOffsetSeconds { get; set; }
}