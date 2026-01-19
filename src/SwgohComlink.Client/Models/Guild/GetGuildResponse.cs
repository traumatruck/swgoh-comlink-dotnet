using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class GetGuildResponse
{
    [JsonPropertyName("guild")]
    public Guild Guild { get; set; }
}