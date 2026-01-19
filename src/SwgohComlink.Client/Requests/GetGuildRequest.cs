using System.Text.Json.Serialization;
using SwgohComlink.Client.Models.Guild;

namespace SwgohComlink.Client.Requests;

public class GetGuildRequest : IRequest<GetGuildResponse>
{
    [JsonPropertyName("payload")]
    public GetGuildRequestPayload Payload { get; set; }

    [JsonPropertyName("enums")]
    public bool? Enums { get; set; }

    public static string Endpoint => "/guild";
    public static HttpMethod HttpMethod => HttpMethod.Post;
}