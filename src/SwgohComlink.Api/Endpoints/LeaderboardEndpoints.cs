using SwgohComlink.Client;
using SwgohComlink.Client.Models.Gac;
using SwgohComlink.Client.Models.Guild;
using SwgohComlink.Client.Requests;

namespace SwgohComlink.Api.Endpoints;

public static class LeaderboardEndpoints
{
    public static IEndpointRouteBuilder MapLeaderboardEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(string.Empty).WithTags("Leaderboard");

        group.MapPost("/getLeaderboard",
                async (GetLeaderboardRequest request, ISwgohComlinkClient client,
                    CancellationToken cancellationToken) =>
                {
                    var response =
                        await client.SendRequestAsync<GetLeaderboardRequest, GetLeaderboardResponse>(request,
                            cancellationToken);

                    return Results.Ok(response);
                })
            .WithSummary("Get player leaderboard data")
            .WithName("GetLeaderboard")
            .Produces<GetLeaderboardResponse>();

        group.MapPost("/getGuildLeaderboard", async (GetGuildLeaderboardRequest request, ISwgohComlinkClient client,
                CancellationToken cancellationToken) =>
            {
                var response =
                    await client.SendRequestAsync<GetGuildLeaderboardRequest, GetGuildLeaderboardResponse>(request,
                        cancellationToken);

                return Results.Ok(response);
            })
            .WithSummary("Get guild leaderboard data")
            .WithName("GetGuildLeaderboard")
            .Produces<GetGuildLeaderboardResponse>();

        return app;
    }
}