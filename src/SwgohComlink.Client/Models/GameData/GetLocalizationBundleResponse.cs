using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class GetLocalizationBundleResponse
{
    [JsonPropertyName("localizationBundle")]
    public string? LocalizationBundle { get; set; }
}