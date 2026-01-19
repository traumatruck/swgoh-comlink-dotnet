using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class GetGuildsResponse
{
    [JsonPropertyName("guild")] public List<GuildProfile> Guild { get; set; }

    [JsonPropertyName("totalRecords")] public int? TotalRecords { get; set; }

    [JsonPropertyName("includeStarterGuild")]
    public bool? IncludeStarterGuild { get; set; }
}