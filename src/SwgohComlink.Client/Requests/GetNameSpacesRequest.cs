using System.Text.Json.Serialization;
using SwgohComlink.Client.Models.GameData;

namespace SwgohComlink.Client.Requests;

public class GetNameSpacesRequest : IRequest<GetNameSpacesResponse>
{
    [JsonPropertyName("payload")]
    public GetNameSpacesRequestPayload Payload { get; set; }

    [JsonPropertyName("enums")]
    public bool? Enums { get; set; }

    public static string Endpoint => "/getNameSpaces";
    public static HttpMethod HttpMethod => HttpMethod.Post;
}