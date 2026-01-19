using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class DatacronHelpEntry
{
    [JsonPropertyName("title")] public string? Title { get; set; }

    [JsonPropertyName("body")] public string? Body { get; set; }
}