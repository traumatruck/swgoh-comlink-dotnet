using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Requests;

public class GetPlayerRequestPayload
{
    [JsonPropertyName("allyCode")]
    public string? AllyCode { get; set; }

    [JsonPropertyName("playerId")]
    public string? PlayerId { get; set; }
}