using SwgohComlink.Client.Models.GameData;
using SwgohComlink.Client.Requests;
using SwgohComlink.MockApi.SampleData;

namespace SwgohComlink.MockApi.Endpoints;

public static class GameDataEndpoints
{
    public static IEndpointRouteBuilder MapGameDataEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(string.Empty).WithTags("Game Data");

        group.MapGet("/enums", () =>
            {
                var response = GameDataMockDataProvider.GetEnumsResponse();
                return Results.Ok(response);
            })
            .WithSummary("Get an object containing all of the game data enums")
            .WithName("GetEnums")
            .Produces<GetEnumsResponse>();

        group.MapPost("/data", (GetGameDataRequest request) =>
            {
                var response = GameDataMockDataProvider.GetGameDataResponse();
                return Results.Ok(response);
            })
            .WithSummary("Get the game data")
            .WithName("GetGameData")
            .Produces<GetGameDataResponse>();

        group.MapPost("/metadata", (GetMetaDataRequest request) =>
            {
                var response = GameDataMockDataProvider.GetMetaDataResponse();
                return Results.Ok(response);
            })
            .WithSummary("Get the game metadata")
            .WithName("GetMetadata")
            .Produces<GetMetaDataResponse>();

        group.MapPost("/localization", (GetLocalizationBundleRequest request) =>
            {
                var response = GameDataMockDataProvider.GetLocalizationBundleResponse();
                return Results.Ok(response);
            })
            .WithSummary("Get the localization bundle")
            .WithName("GetLocalizationBundle")
            .Produces<GetLocalizationBundleResponse>();

        group.MapPost("/getSegmentedContent", (GetSegmentedContentRequest request) =>
            {
                var response = GameDataMockDataProvider.GetSegmentedContentResponse();
                return Results.Ok(response);
            })
            .WithSummary("Get the segmented content details")
            .WithName("GetSegmentedContent")
            .Produces<GetSegmentedContentResponse>();

        group.MapPost("/getNameSpaces", (GetNameSpacesRequest request) =>
            {
                var response = GameDataMockDataProvider.GetNameSpacesResponse();
                return Results.Ok(response);
            })
            .WithSummary("Get the available namespaces")
            .WithName("GetNameSpaces")
            .Produces<GetNameSpacesResponse>();

        return app;
    }
}
