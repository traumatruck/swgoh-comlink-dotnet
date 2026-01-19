using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class SeasonRewardTableKey
{
    [JsonPropertyName("league")]
    public int? League { get; set; }

    [JsonPropertyName("division")]
    public int? Division { get; set; }

    [JsonPropertyName("rank")]
    public int? Rank { get; set; }

}