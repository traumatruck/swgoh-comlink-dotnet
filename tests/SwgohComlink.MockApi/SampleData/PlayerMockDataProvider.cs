using SwgohComlink.Client.Models;
using SwgohComlink.Client.Models.Player;

namespace SwgohComlink.MockApi.SampleData;

/// <summary>
///     Provides mock data for player-related endpoints.
/// </summary>
public static class PlayerMockDataProvider
{
    public static GetPlayerResponse? GetPlayerResponse(string? playerId, string? allyCode)
    {
        // Return null for unknown players to simulate not found
        if (string.IsNullOrEmpty(playerId) && string.IsNullOrEmpty(allyCode))
        {
            return null;
        }

        // Match by player ID or ally code
        if (playerId == MockTestIds.TestPlayerId1 || allyCode == MockTestIds.TestAllyCode1)
        {
            return CreateMockPlayer(MockTestIds.TestPlayerId1, 123456789, "Test Player One", 85);
        }

        if (playerId == MockTestIds.TestPlayerId2 || allyCode == MockTestIds.TestAllyCode2)
        {
            return CreateMockPlayer(MockTestIds.TestPlayerId2, 987654321, "Test Player Two", 90);
        }

        // Return a generic player for any other valid request
        return CreateMockPlayer(playerId ?? "unknown", 0, "Unknown Player", 1);
    }

    public static GetPlayerArenaProfileResponse? GetPlayerArenaProfileResponse(string? playerId, string? allyCode)
    {
        if (string.IsNullOrEmpty(playerId) && string.IsNullOrEmpty(allyCode))
        {
            return null;
        }

        return new GetPlayerArenaProfileResponse
        {
            Name = playerId == MockTestIds.TestPlayerId1 ? "Test Player One" : "Test Player Two",
            AllyCode = 123456789,
            PlayerId = playerId ?? MockTestIds.TestPlayerId1,
            Level = 85,
            PvpProfile =
            [
                new PlayerPvpProfile
                {
                    Rank = 100
                }
            ]
        };
    }

    private static GetPlayerResponse CreateMockPlayer(string playerId, long allyCode, string name, int level)
    {
        return new GetPlayerResponse
        {
            PlayerId = playerId,
            AllyCode = allyCode,
            Name = name,
            Level = level,
            GuildId = MockTestIds.TestGuildId1,
            GuildName = "Test Guild Alpha",
            ProfileStat =
            [
                new PlayerProfileStat
                {
                    NameKey = "GALACTIC_POWER",
                    Value = 5000000
                },

                new PlayerProfileStat
                {
                    NameKey = "CHARACTER_COUNT",
                    Value = 150
                },

                new PlayerProfileStat
                {
                    NameKey = "SHIP_COUNT",
                    Value = 50
                }
            ],
            RosterUnit =
            [
                new Unit
                {
                    Id = "roster-001",
                    DefinitionId = "UNIT_001",
                    CurrentLevel = level
                },

                new Unit
                {
                    Id = "roster-002",
                    DefinitionId = "UNIT_002",
                    CurrentLevel = level
                }
            ],
            PvpProfile =
            [
                new PlayerPvpProfile
                {
                    Rank = 100
                },

                new PlayerPvpProfile
                {
                    Rank = 50
                }
            ]
        };
    }
}