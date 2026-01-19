using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class SeasonRewardTable
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("row")]
    public List<SeasonRewardTableRow> Row { get; set; }

}