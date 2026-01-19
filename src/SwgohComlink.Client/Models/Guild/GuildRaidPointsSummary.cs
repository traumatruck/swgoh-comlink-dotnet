using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class GuildRaidPointsSummary
{
    [JsonPropertyName("identifier")]
    public CampaignElementIdentifier Identifier { get; set; }

    [JsonPropertyName("totalPoints")]
    public long? TotalPoints { get; set; }

}