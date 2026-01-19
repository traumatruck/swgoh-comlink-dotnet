using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryPlayerStat
{
    [JsonPropertyName("memberId")]
    public string? MemberId { get; set; }

    [JsonPropertyName("score")]
    public long? Score { get; set; }

    [JsonPropertyName("covertZoneResult")]
    public List<TerritoryStatCovertZoneResult> CovertZoneResult { get; set; }

}