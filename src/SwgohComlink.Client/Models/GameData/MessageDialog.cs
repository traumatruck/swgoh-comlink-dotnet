using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class MessageDialog
{
    [JsonPropertyName("titleKey")]
    public string? TitleKey { get; set; }

    [JsonPropertyName("descKey")]
    public string? DescKey { get; set; }

}