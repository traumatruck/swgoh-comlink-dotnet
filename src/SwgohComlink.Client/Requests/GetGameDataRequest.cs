using System.Text.Json.Serialization;
using SwgohComlink.Client.Models.GameData;

namespace SwgohComlink.Client.Requests;

public class GetGameDataRequest : IRequest<GetGameDataResponse>
{
    [JsonPropertyName("payload")]
    public GetGameDataRequestPayload Payload { get; set; }

    [JsonPropertyName("enums")]
    public bool? Enums { get; set; }

    public static string Endpoint => "/data";
    public static HttpMethod HttpMethod => HttpMethod.Post;
}