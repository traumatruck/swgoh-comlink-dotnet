using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class RaidPointsStructure
{
    [JsonPropertyName("blackboardPointSource")]
    public List<RaidBlackboardPointSource> BlackboardPointSource { get; set; }

    [JsonPropertyName("modifier")]
    public List<RaidModifier> Modifier { get; set; }
}