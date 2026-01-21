using SwgohComlink.Client.Models.Metrics;

namespace SwgohComlink.Client.Requests;

public class GetMetricsRequest : IRequest<PlainSuccessResponse>
{
    public static string Endpoint => "/metrics";
    public static HttpMethod HttpMethod => HttpMethod.Get;
    public static bool IsPlainTextResponse => true;
}