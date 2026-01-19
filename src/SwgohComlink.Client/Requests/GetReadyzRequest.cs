using SwgohComlink.Client.Models.Readyz;

namespace SwgohComlink.Client.Requests;

public class GetReadyzRequest : IRequest<SuccessResponse>
{
    public static string Endpoint => "/readyz";
    public static HttpMethod HttpMethod => HttpMethod.Get;
}