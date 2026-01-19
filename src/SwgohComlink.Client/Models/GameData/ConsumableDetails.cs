using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ConsumableDetails
{
    [JsonPropertyName("typeId")]
    public string? TypeId { get; set; }

    [JsonPropertyName("maxCount")]
    public int? MaxCount { get; set; }

}