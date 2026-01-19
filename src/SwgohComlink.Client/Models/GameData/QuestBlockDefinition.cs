using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class QuestBlockDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("questPreview")]
    public List<QuestPreview> QuestPreview { get; set; }

    [JsonPropertyName("headlineReward")]
    public BucketItem HeadlineReward { get; set; }

    [JsonPropertyName("headlineQuestCompleteRequirement")]
    public int? HeadlineQuestCompleteRequirement { get; set; }

}