using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class GuildRaidConfig
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("raidType")]
    public GuildRaidType RaidType { get; set; }

    [JsonPropertyName("rosterRefreshType")]
    public GuildRaidRosterRefreshType RosterRefreshType { get; set; }

    [JsonPropertyName("rosterRefresh")]
    public GuildRaidRosterRefresh RosterRefresh { get; set; }

    [JsonPropertyName("raidDuration")]
    public long? RaidDuration { get; set; }
}