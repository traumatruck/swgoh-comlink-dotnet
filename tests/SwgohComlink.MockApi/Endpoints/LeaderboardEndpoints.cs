using SwgohComlink.Client.Models.Gac;
using SwgohComlink.Client.Models.Guild;
using SwgohComlink.Client.Requests;
using SwgohComlink.MockApi.SampleData;

namespace SwgohComlink.MockApi.Endpoints;

public static class LeaderboardEndpoints
{
    public static IEndpointRouteBuilder MapLeaderboardEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(string.Empty).WithTags("Leaderboard");

        group.MapPost("/getLeaderboard", (GetLeaderboardRequest request) =>
            {
                var response = LeaderboardMockDataProvider.GetLeaderboardResponse();
                return Results.Ok(response);
            })
            .WithSummary("Get player leaderboard data")
            .WithName("GetLeaderboard")
            .Produces<GetLeaderboardResponse>();

        group.MapPost("/getGuildLeaderboard", (GetGuildLeaderboardRequest request) =>
            {
                var response = LeaderboardMockDataProvider.GetGuildLeaderboardResponse();
                return Results.Ok(response);
            })
            .WithSummary("Get guild leaderboard data")
            .WithName("GetGuildLeaderboard")
            .Produces<GetGuildLeaderboardResponse>();

        return app;
    }
}
