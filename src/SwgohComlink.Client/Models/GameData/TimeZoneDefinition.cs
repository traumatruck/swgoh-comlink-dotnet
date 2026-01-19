using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TimeZoneDefinition
{
    [JsonPropertyName("timeZoneOffsetMinutes")]
    public int? TimeZoneOffsetMinutes { get; set; }

    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

}