using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class CampaignCinematic
{
    [JsonPropertyName("trigger")] public CinematicTrigger Trigger { get; set; }

    [JsonPropertyName("environment")] public Environment Environment { get; set; }

    [JsonPropertyName("subsequentViewingEnvironment")]
    public Environment SubsequentViewingEnvironment { get; set; }
}