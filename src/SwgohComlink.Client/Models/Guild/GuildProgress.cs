using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class GuildProgress
{
    [JsonPropertyName("raidProgress")]
    public List<GuildRaidProgress> RaidProgress { get; set; }
}