using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class AbilitySynergy
{
    [JsonPropertyName("separateCategoryId")]
    public List<string?> SeparateCategoryId { get; set; }

    [JsonPropertyName("groupedCategoryId")]
    public List<string?> GroupedCategoryId { get; set; }

}