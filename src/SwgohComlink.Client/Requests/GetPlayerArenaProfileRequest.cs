using System.Text.Json.Serialization;
using SwgohComlink.Client.Models.Player;

namespace SwgohComlink.Client.Requests;

public class GetPlayerArenaProfileRequest : IRequest<GetPlayerArenaProfileResponse>
{
    [JsonPropertyName("payload")]
    public GetPlayerRequestPayload Payload { get; set; }

    [JsonPropertyName("enums")]
    public bool? Enums { get; set; }

    public static string Endpoint => "/playerArena";
    public static HttpMethod HttpMethod => HttpMethod.Post;
}