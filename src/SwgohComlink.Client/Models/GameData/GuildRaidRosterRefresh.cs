using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class GuildRaidRosterRefresh
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public List<int?> Value { get; set; }

}