using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class GraduatingTerritoryReward
{
    [JsonPropertyName("defendNumber")]
    public int? DefendNumber { get; set; }

    [JsonPropertyName("reward")]
    public TerritoryReward Reward { get; set; }
}