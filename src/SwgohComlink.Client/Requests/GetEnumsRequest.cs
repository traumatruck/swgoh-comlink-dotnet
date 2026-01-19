using SwgohComlink.Client.Models.GameData;

namespace SwgohComlink.Client.Requests;

public class GetEnumsRequest : IRequest<GetEnumsResponse>
{
    public static string Endpoint => "/enums";
    public static HttpMethod HttpMethod => HttpMethod.Get;
}