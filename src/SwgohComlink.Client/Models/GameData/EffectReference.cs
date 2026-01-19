using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class EffectReference
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("contextIndex")]
    public List<int?> ContextIndex { get; set; }

    [JsonPropertyName("maxBonusMove")]
    public int? MaxBonusMove { get; set; }

}