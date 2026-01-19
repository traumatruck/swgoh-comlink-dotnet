using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class UnitReplacement
{
    [JsonPropertyName("sourceUnitId")]
    public string? SourceUnitId { get; set; }

    [JsonPropertyName("replacementUnitId")]
    public string? ReplacementUnitId { get; set; }
}