using System.Text.Json.Serialization;
using SwgohComlink.Client.Models.Events;

namespace SwgohComlink.Client.Requests;

public class GetEventsRequest : IRequest<GetEventsResponse>
{
    [JsonPropertyName("payload")]
    public GetEventsRequestPayload Payload { get; set; }

    [JsonPropertyName("enums")]
    public bool? Enums { get; set; }

    public static string Endpoint => "/getEvents";
    public static HttpMethod HttpMethod => HttpMethod.Post;
}