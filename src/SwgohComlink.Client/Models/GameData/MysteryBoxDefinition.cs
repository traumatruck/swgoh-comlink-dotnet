using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class MysteryBoxDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("texture")]
    public string? Texture { get; set; }

    [JsonPropertyName("titleKey")]
    public string? TitleKey { get; set; }

    [JsonPropertyName("descKey")]
    public string? DescKey { get; set; }

    [JsonPropertyName("detailsTitleKey")]
    public string? DetailsTitleKey { get; set; }

    [JsonPropertyName("detailsDescKey")]
    public string? DetailsDescKey { get; set; }

    [JsonPropertyName("iconTextKey")]
    public string? IconTextKey { get; set; }

    [JsonPropertyName("previewItem")]
    public List<BucketItem> PreviewItem { get; set; }

    [JsonPropertyName("showPrimaryRewards")]
    public bool? ShowPrimaryRewards { get; set; }

}