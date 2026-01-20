using SwgohComlink.Client.Models.Events;
using SwgohComlink.Client.Requests;
using SwgohComlink.MockApi.SampleData;

namespace SwgohComlink.MockApi.Endpoints;

public static class EventEndpoints
{
    public static IEndpointRouteBuilder MapEventEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(string.Empty).WithTags("Events");

        group.MapPost("/getEvents", (GetEventsRequest? _) =>
            {
                var response = EventMockDataProvider.GetEventsResponse();
                return Results.Ok(response);
            })
            .WithSummary("Get the game events")
            .WithName("GetEvents")
            .Produces<GetEventsResponse>();

        return app;
    }
}