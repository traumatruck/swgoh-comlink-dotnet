using SwgohComlink.Client;
using SwgohComlink.Client.Models.GameData;
using SwgohComlink.Client.Requests;

namespace SwgohComlink.Api.Endpoints;

public static class GameDataEndpoints
{
    public static IEndpointRouteBuilder MapGameDataEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(string.Empty).WithTags("Game Data");

        group.MapGet("/enums", async (ISwgohComlinkClient client, CancellationToken cancellationToken) =>
            {
                var response =
                    await client.SendRequestAsync<GetEnumsRequest, GetEnumsResponse>(new GetEnumsRequest(),
                        cancellationToken);

                return Results.Ok(response);
            })
            .WithSummary("Get an object containing all of the game data enums")
            .WithName("GetEnums")
            .Produces<GetEnumsResponse>();

        group.MapPost("/data",
                async (GetGameDataRequest request, ISwgohComlinkClient client, CancellationToken cancellationToken) =>
                {
                    var response =
                        await client.SendRequestAsync<GetGameDataRequest, GetGameDataResponse>(request,
                            cancellationToken);

                    return Results.Ok(response);
                })
            .WithSummary("Get the game data")
            .WithName("GetGameData")
            .Produces<GetGameDataResponse>();

        group.MapPost("/metadata",
                async (GetMetaDataRequest request, ISwgohComlinkClient client, CancellationToken cancellationToken) =>
                {
                    var response =
                        await client.SendRequestAsync<GetMetaDataRequest, GetMetaDataResponse>(request,
                            cancellationToken);

                    return Results.Ok(response);
                })
            .WithSummary("Get the game metadata")
            .WithName("GetMetadata")
            .Produces<GetMetaDataResponse>();

        group.MapPost("/localization",
                async (GetLocalizationBundleRequest request, ISwgohComlinkClient client,
                    CancellationToken cancellationToken) =>
                {
                    var response =
                        await client.SendRequestAsync<GetLocalizationBundleRequest, GetLocalizationBundleResponse>(
                            request,
                            cancellationToken);

                    return Results.Ok(response);
                })
            .WithSummary("Get the localization bundle")
            .WithName("GetLocalizationBundle")
            .Produces<GetLocalizationBundleResponse>();

        group.MapPost("/getSegmentedContent", async (GetSegmentedContentRequest request, ISwgohComlinkClient client,
                CancellationToken cancellationToken) =>
            {
                var response =
                    await client.SendRequestAsync<GetSegmentedContentRequest, GetSegmentedContentResponse>(request,
                        cancellationToken);

                return Results.Ok(response);
            })
            .WithSummary("Get the segmented content details")
            .WithName("GetSegmentedContent")
            .Produces<GetSegmentedContentResponse>();

        group.MapPost("/getNameSpaces",
                async (GetNameSpacesRequest request, ISwgohComlinkClient client, CancellationToken cancellationToken) =>
                {
                    var response =
                        await client.SendRequestAsync<GetNameSpacesRequest, GetNameSpacesResponse>(request,
                            cancellationToken);

                    return Results.Ok(response);
                })
            .WithSummary("Get the available namespaces")
            .WithName("GetNameSpaces")
            .Produces<GetNameSpacesResponse>();

        return app;
    }
}