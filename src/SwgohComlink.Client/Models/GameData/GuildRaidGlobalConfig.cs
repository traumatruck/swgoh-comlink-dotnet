using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class GuildRaidGlobalConfig
{
    [JsonPropertyName("guildRaidLockout")]
    public GuildRaidLockout GuildRaidLockout { get; set; }

    [JsonPropertyName("lateEntryParticipationLockoutSeconds")]
    public long? LateEntryParticipationLockoutSeconds { get; set; }

}