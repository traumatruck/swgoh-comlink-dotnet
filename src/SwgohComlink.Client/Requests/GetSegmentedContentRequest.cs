using System.Text.Json.Serialization;
using SwgohComlink.Client.Models.GameData;

namespace SwgohComlink.Client.Requests;

public class GetSegmentedContentRequest : IRequest<GetSegmentedContentResponse>
{
    [JsonPropertyName("payload")]
    public GetSegmentedContentRequestPayload Payload { get; set; }

    [JsonPropertyName("enums")]
    public bool? Enums { get; set; }

    public static string Endpoint => "/getSegmentedContent";
    public static HttpMethod HttpMethod => HttpMethod.Post;
}