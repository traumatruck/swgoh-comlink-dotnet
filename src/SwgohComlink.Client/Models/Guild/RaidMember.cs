using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class RaidMember
{
    [JsonPropertyName("playerId")]
    public string? PlayerId { get; set; }

    [JsonPropertyName("memberProgress")]
    public long? MemberProgress { get; set; }

    [JsonPropertyName("memberRank")]
    public int? MemberRank { get; set; }

    [JsonPropertyName("memberAttempt")]
    public int? MemberAttempt { get; set; }

}