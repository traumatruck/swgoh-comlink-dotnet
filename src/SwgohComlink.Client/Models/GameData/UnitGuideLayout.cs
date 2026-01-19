using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class UnitGuideLayout
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("tabTitleKey")]
    public string? TabTitleKey { get; set; }

    [JsonPropertyName("layoutTier")]
    public List<UnitGuideLayoutTier> LayoutTier { get; set; }

}