using SwgohComlink.Client.Models.Guild;
using SwgohComlink.Client.Requests;
using SwgohComlink.MockApi.SampleData;

namespace SwgohComlink.MockApi.Endpoints;

public static class GuildEndpoints
{
    public static IEndpointRouteBuilder MapGuildEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(string.Empty).WithTags("Guild");

        group.MapPost("/guild", (GetGuildRequest request) =>
            {
                var guildId = request.Payload.GuildId;

                var response = GuildMockDataProvider.GetGuildResponse(guildId);

                return response == null ? Results.NotFound(new { error = "Guild not found" }) : Results.Ok(response);
            })
            .WithSummary("Get a guild's full profile data")
            .WithName("GetGuild")
            .Produces<GetGuildResponse>();

        group.MapPost("/getGuilds", (GetGuildsRequest request) =>
            {
                var response = GuildMockDataProvider.GetGuildsResponse(request.Payload);
                return Results.Ok(response);
            })
            .WithSummary("Search for guilds")
            .WithName("GetGuilds")
            .Produces<GetGuildsResponse>();

        return app;
    }
}