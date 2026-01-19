using System.Text.Json.Serialization;
using SwgohComlink.Client.Models.GameData;

namespace SwgohComlink.Client.Requests;

public class GetLocalizationBundleRequest : IRequest<GetLocalizationBundleResponse>
{
    [JsonPropertyName("unzip")]
    public bool? Unzip { get; set; }

    [JsonPropertyName("payload")]
    public GetLocalizationBundleRequestPayload Payload { get; set; }

    [JsonPropertyName("enums")]
    public bool? Enums { get; set; }

    public static string Endpoint => "/localization";
    public static HttpMethod HttpMethod => HttpMethod.Post;
}