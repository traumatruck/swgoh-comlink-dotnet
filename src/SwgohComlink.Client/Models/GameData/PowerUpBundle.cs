using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class PowerUpBundle
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("targetLevel")]
    public int? TargetLevel { get; set; }

    [JsonPropertyName("targetGearTier")]
    public UnitTier TargetGearTier { get; set; }

    [JsonPropertyName("autoSelectTier")]
    public bool? AutoSelectTier { get; set; }

}