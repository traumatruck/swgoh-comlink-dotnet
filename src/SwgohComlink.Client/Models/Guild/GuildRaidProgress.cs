using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class GuildRaidProgress
{
    [JsonPropertyName("identifier")]
    public CampaignElementIdentifier Identifier { get; set; }

    [JsonPropertyName("progress")]
    public CampaignElementProgress Progress { get; set; }

    [JsonPropertyName("winCount")]
    public int? WinCount { get; set; }
}