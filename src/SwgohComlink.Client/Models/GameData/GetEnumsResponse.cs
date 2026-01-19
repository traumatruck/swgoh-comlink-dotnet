using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class GetEnumsResponse
{
    [JsonExtensionData]
    public Dictionary<string, object>? Enums { get; set; }
}