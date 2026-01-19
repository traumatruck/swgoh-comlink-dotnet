using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class CinematicTrigger
{
    [JsonPropertyName("triggerCondition")]
    public string? TriggerCondition { get; set; }

}