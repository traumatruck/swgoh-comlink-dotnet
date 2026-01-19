using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class Guild
{
    [JsonPropertyName("profile")]
    public GuildProfile Profile { get; set; }

    [JsonPropertyName("member")]
    public List<GuildMember> Member { get; set; }

    [JsonPropertyName("inviteStatus")]
    public List<GuildInviteStatus> InviteStatus { get; set; }

    [JsonPropertyName("raidStatus")]
    public List<GuildRaidStatus> RaidStatus { get; set; }

    [JsonPropertyName("inventory")]
    public GuildInventory Inventory { get; set; }

    [JsonPropertyName("raidResult")]
    public List<GuildRaidResult> RaidResult { get; set; }

    [JsonPropertyName("progress")]
    public GuildProgress Progress { get; set; }

    [JsonPropertyName("territoryBattleStatus")]
    public List<TerritoryBattleStatus> TerritoryBattleStatus { get; set; }

    [JsonPropertyName("guildEvents")]
    public List<GameEvent> GuildEvents { get; set; }

    [JsonPropertyName("territoryBattleResult")]
    public List<TerritoryBattleResult> TerritoryBattleResult { get; set; }

    [JsonPropertyName("territoryWarStatus")]
    public List<TerritoryWarStatus> TerritoryWarStatus { get; set; }

    [JsonPropertyName("roomAvailable")]
    public List<RoomData> RoomAvailable { get; set; }

    [JsonPropertyName("nextChallengesRefresh")]
    public long? NextChallengesRefresh { get; set; }

    [JsonPropertyName("stat")]
    public List<GuildStat> Stat { get; set; }

    [JsonPropertyName("recentRaidResult")]
    public List<GuildRaidResult> RecentRaidResult { get; set; }

    [JsonPropertyName("recentTerritoryWarResult")]
    public List<TerritoryWarResult> RecentTerritoryWarResult { get; set; }

    [JsonPropertyName("lastRaidPointsSummary")]
    public List<GuildRaidPointsSummary> LastRaidPointsSummary { get; set; }
}