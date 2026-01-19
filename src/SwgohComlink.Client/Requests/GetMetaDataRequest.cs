using System.Text.Json.Serialization;
using SwgohComlink.Client.Models.GameData;

namespace SwgohComlink.Client.Requests;

public class GetMetaDataRequest : IRequest<GetMetaDataResponse>
{
    [JsonPropertyName("payload")]
    public GetMetaDataRequestPayload Payload { get; set; }

    [JsonPropertyName("enums")]
    public bool? Enums { get; set; }

    public static string Endpoint => "/metadata";
    public static HttpMethod HttpMethod => HttpMethod.Post;
}