using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class WarDef
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public CombatType Type { get; set; }

    [JsonPropertyName("difficulty")]
    public CampaignNodeDifficulty Difficulty { get; set; }

    [JsonPropertyName("dailyResetCapKey")]
    public string? DailyResetCapKey { get; set; }

    [JsonPropertyName("node")]
    public List<WarNodeDef> Node { get; set; }

    [JsonPropertyName("bracket")]
    public List<WarBracketDef> Bracket { get; set; }
}