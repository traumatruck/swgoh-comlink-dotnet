using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class ScaleItemModifier
{
    [JsonPropertyName("scale")]
    public int? Scale { get; set; }

    [JsonPropertyName("target")]
    public List<ModifierItem> Target { get; set; }
}