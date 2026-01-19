using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class EnergyRewardInstance
{
    [JsonPropertyName("type")]
    public EnergyRewardInstanceType Type { get; set; }

    [JsonPropertyName("start")]
    public int? Start { get; set; }

    [JsonPropertyName("duration")]
    public int? Duration { get; set; }

    [JsonPropertyName("amount")]
    public int? Amount { get; set; }

}