using SwgohComlink.Client;
using SwgohComlink.Client.Models.Events;
using SwgohComlink.Client.Requests;

namespace SwgohComlink.Api.Endpoints;

public static class EventEndpoints
{
    public static IEndpointRouteBuilder MapEventEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(string.Empty).WithTags("Events");

        group.MapPost("/getEvents",
                async (GetEventsRequest request, ISwgohComlinkClient client, CancellationToken cancellationToken) =>
                {
                    var response =
                        await client.SendRequestAsync<GetEventsRequest, GetEventsResponse>(request, cancellationToken);
                    
                    return Results.Ok(response);
                })
            .WithSummary("Get the game events")
            .WithName("GetEvents")
            .Produces<GetEventsResponse>();

        return app;
    }
}