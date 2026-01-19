using SwgohComlink.Client;
using SwgohComlink.Client.Models.Player;
using SwgohComlink.Client.Requests;

namespace SwgohComlink.Api.Endpoints;

public static class PlayerEndpoints
{
    public static IEndpointRouteBuilder MapPlayerEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(string.Empty).WithTags("Player");

        group.MapPost("/player",
                async (GetPlayerRequest request, ISwgohComlinkClient client, CancellationToken cancellationToken) =>
                {
                    var response =
                        await client.SendRequestAsync<GetPlayerRequest, GetPlayerResponse>(request, cancellationToken);

                    return Results.Ok(response);
                })
            .WithSummary("Get a player's full profile data")
            .WithName("GetPlayer")
            .Produces<GetPlayerResponse>();

        group.MapPost("/playerArena",
                async (GetPlayerArenaProfileRequest request, ISwgohComlinkClient client,
                    CancellationToken cancellationToken) =>
                {
                    var response =
                        await client.SendRequestAsync<GetPlayerArenaProfileRequest, GetPlayerArenaProfileResponse>(
                            request,
                            cancellationToken);

                    return Results.Ok(response);
                })
            .WithSummary("Get a player's arena profile")
            .WithName("GetPlayerArenaProfile")
            .Produces<GetPlayerArenaProfileResponse>();

        return app;
    }
}