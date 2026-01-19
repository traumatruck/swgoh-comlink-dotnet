using SwgohComlink.Client.Models.Readyz;

namespace SwgohComlink.Client.Requests;

public class GetLivezRequest : IRequest<SuccessResponse>
{
    public static string Endpoint => "/livez";
    public static HttpMethod HttpMethod => HttpMethod.Get;
}