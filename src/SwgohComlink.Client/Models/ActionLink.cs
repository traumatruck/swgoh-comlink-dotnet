using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class ActionLink
{
    [JsonPropertyName("link")]
    public string? Link { get; set; }

    [JsonPropertyName("type")]
    public ActionLinkType Type { get; set; }
}