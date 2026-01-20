using SwgohComlink.Client.Models.Metrics;
using SwgohComlink.Client.Models.Readyz;

namespace SwgohComlink.MockApi.Endpoints;

public static class HealthEndpoints
{
    public static IEndpointRouteBuilder MapHealthEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(string.Empty).WithTags("Health");

        group.MapGet("/metrics", () =>
            {
                // Return mock prometheus metrics
                const string metrics = """
                                       # HELP swgoh_comlink_requests_total Total number of requests
                                       # TYPE swgoh_comlink_requests_total counter
                                       swgoh_comlink_requests_total{endpoint="player"} 100
                                       swgoh_comlink_requests_total{endpoint="guild"} 50
                                       # HELP swgoh_comlink_request_duration_seconds Request duration in seconds
                                       # TYPE swgoh_comlink_request_duration_seconds histogram
                                       swgoh_comlink_request_duration_seconds_bucket{le="0.1"} 80
                                       swgoh_comlink_request_duration_seconds_bucket{le="0.5"} 95
                                       swgoh_comlink_request_duration_seconds_bucket{le="1"} 100
                                       """;

                return Results.Ok(new PlainSuccessResponse { Value = metrics });
            })
            .WithSummary("Get prometheus metrics")
            .WithName("GetMetrics")
            .Produces<PlainSuccessResponse>();

        group.MapGet("/readyz", () => Results.Ok(new SuccessResponse()))
            .WithSummary("Endpoint to check if the service is ready")
            .WithName("GetReadyz")
            .Produces<SuccessResponse>();

        group.MapGet("/livez", () => Results.Ok(new SuccessResponse()))
            .WithSummary("Endpoint to check if the service is alive")
            .WithName("GetLivez")
            .Produces<SuccessResponse>();

        return app;
    }
}