using System.Text.Json.Serialization;
using SwgohComlink.Client.Models.Guild;

namespace SwgohComlink.Client.Requests;

public class GetGuildsRequest : IRequest<GetGuildsResponse>
{
    [JsonPropertyName("payload")]
    public GetGuildsRequestPayload Payload { get; set; }

    [JsonPropertyName("enums")]
    public bool? Enums { get; set; }

    public static string Endpoint => "/getGuilds";
    public static HttpMethod HttpMethod => HttpMethod.Post;
}