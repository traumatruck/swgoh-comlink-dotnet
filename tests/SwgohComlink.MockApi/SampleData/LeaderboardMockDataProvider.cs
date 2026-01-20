using SwgohComlink.Client.Models.Gac;
using SwgohComlink.Client.Models.Guild;

namespace SwgohComlink.MockApi.SampleData;

/// <summary>
///     Provides mock data for leaderboard-related endpoints.
/// </summary>
public static class LeaderboardMockDataProvider
{
    public static GetLeaderboardResponse GetLeaderboardResponse()
    {
        return new GetLeaderboardResponse
        {
            Player =
            [
                new LeaderboardPlayer
                {
                    Id = MockTestIds.TestPlayerId1,
                    Name = "Test Player One"
                },

                new LeaderboardPlayer
                {
                    Id = MockTestIds.TestPlayerId2,
                    Name = "Test Player Two"
                }
            ]
        };
    }

    public static GetGuildLeaderboardResponse GetGuildLeaderboardResponse()
    {
        return new GetGuildLeaderboardResponse
        {
            Leaderboard =
            [
                new GuildLeaderboard
                {
                    Guild =
                    [
                        new GuildProfile
                        {
                            Id = MockTestIds.TestGuildId1,
                            Name = "Test Guild Alpha",
                            MemberCount = 50
                        },

                        new GuildProfile
                        {
                            Id = MockTestIds.TestGuildId2,
                            Name = "Test Guild Beta",
                            MemberCount = 45
                        }
                    ]
                }
            ]
        };
    }
}