using SwgohComlink.Client.Models.Player;
using SwgohComlink.Client.Requests;
using SwgohComlink.MockApi.SampleData;

namespace SwgohComlink.MockApi.Endpoints;

public static class PlayerEndpoints
{
    public static IEndpointRouteBuilder MapPlayerEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(string.Empty).WithTags("Player");

        group.MapPost("/player", (GetPlayerRequest request) =>
            {
                var playerId = request.Payload?.PlayerId;
                var allyCode = request.Payload?.AllyCode;

                // Return mock player data
                var response = PlayerMockDataProvider.GetPlayerResponse(playerId, allyCode);
                
                if (response == null)
                {
                    return Results.NotFound(new { error = "Player not found" });
                }

                return Results.Ok(response);
            })
            .WithSummary("Get a player's full profile data")
            .WithName("GetPlayer")
            .Produces<GetPlayerResponse>();

        group.MapPost("/playerArena", (GetPlayerArenaProfileRequest request) =>
            {
                var playerId = request.Payload?.PlayerId;
                var allyCode = request.Payload?.AllyCode;

                var response = PlayerMockDataProvider.GetPlayerArenaProfileResponse(playerId, allyCode);
                
                if (response == null)
                {
                    return Results.NotFound(new { error = "Player not found" });
                }

                return Results.Ok(response);
            })
            .WithSummary("Get a player's arena profile")
            .WithName("GetPlayerArenaProfile")
            .Produces<GetPlayerArenaProfileResponse>();

        return app;
    }
}
