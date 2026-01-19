using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryWarParticipant
{
    [JsonPropertyName("memberId")]
    public string? MemberId { get; set; }

    [JsonPropertyName("joinTime")]
    public long? JoinTime { get; set; }

    [JsonPropertyName("eligible")]
    public bool? Eligible { get; set; }

    [JsonPropertyName("power")]
    public int? Power { get; set; }
}