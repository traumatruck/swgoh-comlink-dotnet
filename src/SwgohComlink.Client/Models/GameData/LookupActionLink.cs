using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class LookupActionLink
{
    [JsonPropertyName("deskKey")]
    public string? DeskKey { get; set; }

    [JsonPropertyName("actionLink")]
    public ActionLink ActionLink { get; set; }

}