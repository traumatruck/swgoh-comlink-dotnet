using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class CharacterQuestLine
{
    [JsonPropertyName("startTime")]
    public long? StartTime { get; set; }

    [JsonPropertyName("endTime")]
    public long? EndTime { get; set; }

    [JsonPropertyName("characterQuestBlock")]
    public List<QuestBlockDefinition> CharacterQuestBlock { get; set; }

    [JsonPropertyName("unitId")]
    public string? UnitId { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("titleKey")]
    public string? TitleKey { get; set; }
}