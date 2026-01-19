using System.Text.Json.Serialization;
using SwgohComlink.Client.Models.Gac;

namespace SwgohComlink.Client.Requests;

public class GetLeaderboardRequest : IRequest<GetLeaderboardResponse>
{
    [JsonPropertyName("payload")]
    public GetLeaderboardRequestPayload Payload { get; set; }

    [JsonPropertyName("enums")]
    public bool? Enums { get; set; }

    public static string Endpoint => "/getLeaderboard";
    public static HttpMethod HttpMethod => HttpMethod.Post;
}