using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class CalendarCategoryDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("unlimited")]
    public bool? Unlimited { get; set; }

    [JsonPropertyName("sortOrder")]
    public int? SortOrder { get; set; }

    [JsonPropertyName("textKey")]
    public string? TextKey { get; set; }

}