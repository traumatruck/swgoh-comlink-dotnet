using SwgohComlink.Client;
using SwgohComlink.Client.Models.Metrics;
using SwgohComlink.Client.Models.Readyz;
using SwgohComlink.Client.Requests;

namespace SwgohComlink.Api.Endpoints;

public static class HealthEndpoints
{
    public static IEndpointRouteBuilder MapHealthEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(string.Empty).WithTags("Health");

        group.MapGet("/metrics", async (ISwgohComlinkClient client, CancellationToken cancellationToken) =>
            {
                var response =
                    await client.SendRequestAsync<GetMetricsRequest, PlainSuccessResponse>(new GetMetricsRequest(),
                        cancellationToken);

                return Results.Ok(response);
            })
            .WithSummary("Get prometheus metrics")
            .WithName("GetMetrics")
            .Produces<PlainSuccessResponse>();

        group.MapGet("/readyz", async (ISwgohComlinkClient client, CancellationToken cancellationToken) =>
            {
                var response =
                    await client.SendRequestAsync<GetReadyzRequest, SuccessResponse>(new GetReadyzRequest(),
                        cancellationToken);

                return Results.Ok(response);
            })
            .WithSummary("Endpoint to check if the service is ready")
            .WithName("GetReadyz")
            .Produces<SuccessResponse>();

        group.MapGet("/livez", async (ISwgohComlinkClient client, CancellationToken cancellationToken) =>
            {
                var response =
                    await client.SendRequestAsync<GetLivezRequest, SuccessResponse>(new GetLivezRequest(),
                        cancellationToken);

                return Results.Ok(response);
            })
            .WithSummary("Endpoint to check if the service is alive")
            .WithName("GetLivez")
            .Produces<SuccessResponse>();

        return app;
    }
}