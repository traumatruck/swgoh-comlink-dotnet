using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class GuildMemberContribution
{
    [JsonPropertyName("type")]
    public MemberContributionType Type { get; set; }

    [JsonPropertyName("currentValue")]
    public long? CurrentValue { get; set; }

    [JsonPropertyName("lifetimeValue")]
    public long? LifetimeValue { get; set; }

}