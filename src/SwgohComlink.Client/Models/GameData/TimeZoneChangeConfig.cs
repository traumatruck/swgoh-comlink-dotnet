using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TimeZoneChangeConfig
{
    [JsonPropertyName("allowedChangesPerPeriod")]
    public int? AllowedChangesPerPeriod { get; set; }

    [JsonPropertyName("allowedChangesLocKey")]
    public string? AllowedChangesLocKey { get; set; }

    [JsonPropertyName("allowedChangesResetLocKey")]
    public string? AllowedChangesResetLocKey { get; set; }

    [JsonPropertyName("maxTimeZoneChangeHoursExclusive")]
    public int? MaxTimeZoneChangeHoursExclusive { get; set; }

    [JsonPropertyName("timeZoneDefinition")]
    public List<TimeZoneDefinition> TimeZoneDefinition { get; set; }

    [JsonPropertyName("timeZoneChangeCooldownId")]
    public string? TimeZoneChangeCooldownId { get; set; }

}