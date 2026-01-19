using System.Text.Json.Serialization;
using SwgohComlink.Client.Models.Guild;

namespace SwgohComlink.Client.Requests;

public class GetGuildLeaderboardRequest : IRequest<GetGuildLeaderboardResponse>
{
    [JsonPropertyName("payload")]
    public GetGuildLeaderboardRequestPayload Payload { get; set; }

    [JsonPropertyName("enums")]
    public bool? Enums { get; set; }

    public static string Endpoint => "/getGuildLeaderboard";
    public static HttpMethod HttpMethod => HttpMethod.Post;
}