using SwgohComlink.Client.Models.GameData;

namespace SwgohComlink.MockApi.SampleData;

/// <summary>
///     Provides mock data for game data-related endpoints.
/// </summary>
public static class GameDataMockDataProvider
{
    public static GetEnumsResponse GetEnumsResponse()
    {
        return new GetEnumsResponse
        {
            Enums = new Dictionary<string, object>
            {
                ["GameEventType"] = new[] { "CONQUEST", "GUILD", "PLAYER" },
                ["GameEventStatus"] = new[] { "ACTIVE", "UPCOMING", "ENDED" },
                ["CombatType"] = new[] { "CHARACTER", "SHIP" },
                ["Rarity"] = new[] { "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN" }
            }
        };
    }

    public static GetGameDataResponse GetGameDataResponse()
    {
        return new GetGameDataResponse
        {
            Units =
            [
                new UnitDef
                {
                    Id = "UNIT_001",
                    BaseId = "jedi_luke",
                    NameKey = "UNIT_JEDI_LUKE_NAME",
                    DescKey = "UNIT_JEDI_LUKE_DESC"
                },

                new UnitDef
                {
                    Id = "UNIT_002",
                    BaseId = "vader",
                    NameKey = "UNIT_VADER_NAME",
                    DescKey = "UNIT_VADER_DESC"
                }
            ],
            Category =
            [
                new Category
                {
                    Id = "CAT_001",
                    DescKey = "Jedi"
                },

                new Category
                {
                    Id = "CAT_002",
                    DescKey = "Sith"
                }
            ]
        };
    }

    public static GetMetaDataResponse GetMetaDataResponse()
    {
        return new GetMetaDataResponse
        {
            ServerTimestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
            LatestGamedataVersion = "0.38.1:mock",
            LatestLocalizationBundleVersion = "0.38.1:mock-loc"
        };
    }

    public static GetLocalizationBundleResponse GetLocalizationBundleResponse()
    {
        return new GetLocalizationBundleResponse
        {
            LocalizationBundle =
                Convert.ToBase64String("UNIT_JEDI_LUKE_NAME|Jedi Knight Luke\nUNIT_VADER_NAME|Darth Vader"u8.ToArray())
        };
    }

    public static GetSegmentedContentResponse GetSegmentedContentResponse()
    {
        return new GetSegmentedContentResponse
        {
            Content = new SegmentedContent
            {
                Segments =
                [
                    new ContentSegment
                    {
                        Name = "default"
                    }
                ]
            }
        };
    }

    public static GetNameSpacesResponse GetNameSpacesResponse()
    {
        return new GetNameSpacesResponse
        {
            NameSpaceValue = ["default", "events", "conquest", "gac"]
        };
    }
}