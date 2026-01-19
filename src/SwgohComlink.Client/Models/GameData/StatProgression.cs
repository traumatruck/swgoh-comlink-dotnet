using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class StatProgression
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("stat")]
    public StatDef Stat { get; set; }

    [JsonPropertyName("operation")]
    public OperationType Operation { get; set; }
}