using SwgohComlink.Client;
using SwgohComlink.Client.Models.Guild;
using SwgohComlink.Client.Requests;

namespace SwgohComlink.Api.Endpoints;

public static class GuildEndpoints
{
    public static IEndpointRouteBuilder MapGuildEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(string.Empty).WithTags("Guild");

        group.MapPost("/guild",
                async (GetGuildRequest request, ISwgohComlinkClient client, CancellationToken cancellationToken) =>
                {
                    var response =
                        await client.SendRequestAsync<GetGuildRequest, GetGuildResponse>(request, cancellationToken);

                    return Results.Ok(response);
                })
            .WithSummary("Get a guild's full profile data")
            .WithName("GetGuild")
            .Produces<GetGuildResponse>();

        group.MapPost("/getGuilds",
                async (GetGuildsRequest request, ISwgohComlinkClient client, CancellationToken cancellationToken) =>
                {
                    var response =
                        await client.SendRequestAsync<GetGuildsRequest, GetGuildsResponse>(request, cancellationToken);

                    return Results.Ok(response);
                })
            .WithSummary("Search for guilds")
            .WithName("GetGuilds")
            .Produces<GetGuildsResponse>();

        return app;
    }
}