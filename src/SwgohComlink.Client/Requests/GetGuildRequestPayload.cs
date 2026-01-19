using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Requests;

public class GetGuildRequestPayload
{
    [JsonPropertyName("guildId")]
    public string? GuildId { get; set; }

    [JsonPropertyName("includeRecentGuildActivityInfo")]
    public bool? IncludeRecentGuildActivityInfo { get; set; }

}