using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Player;

public class EraUnitStatus
{
    [JsonPropertyName("unitBaseId")]
    public string? UnitBaseId { get; set; }

    [JsonPropertyName("eraLevel")]
    public int? EraLevel { get; set; }

}