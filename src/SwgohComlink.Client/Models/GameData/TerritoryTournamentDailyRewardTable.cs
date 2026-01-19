using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TerritoryTournamentDailyRewardTable
{
    [JsonPropertyName("row")]
    public List<TerritoryTournamentDailyRewardTableRow> Row { get; set; }
}