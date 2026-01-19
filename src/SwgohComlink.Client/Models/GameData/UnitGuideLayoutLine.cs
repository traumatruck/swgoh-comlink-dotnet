using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class UnitGuideLayoutLine
{
    [JsonPropertyName("unitGuideId")]
    public List<string?> UnitGuideId { get; set; }

}