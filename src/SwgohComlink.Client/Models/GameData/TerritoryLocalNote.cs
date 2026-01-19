using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TerritoryLocalNote
{
    [JsonPropertyName("messageKey")]
    public string? MessageKey { get; set; }

    [JsonPropertyName("titleKey")]
    public string? TitleKey { get; set; }

    [JsonPropertyName("optedIn")]
    public bool? OptedIn { get; set; }

    [JsonPropertyName("phase")]
    public TerritoryMapPhase Phase { get; set; }

    [JsonPropertyName("phaseTimeOffsetSeconds")]
    public int? PhaseTimeOffsetSeconds { get; set; }

    [JsonPropertyName("finalMatchOnly")]
    public bool? FinalMatchOnly { get; set; }

    [JsonPropertyName("perSubPhaseRoundEnd")]
    public bool? PerSubPhaseRoundEnd { get; set; }

}