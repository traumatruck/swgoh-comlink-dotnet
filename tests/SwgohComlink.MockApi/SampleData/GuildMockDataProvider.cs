using SwgohComlink.Client.Models.Guild;
using SwgohComlink.Client.Requests;

namespace SwgohComlink.MockApi.SampleData;

/// <summary>
///     Provides mock data for guild-related endpoints.
/// </summary>
public static class GuildMockDataProvider
{
    public static GetGuildResponse? GetGuildResponse(string? guildId)
    {
        if (string.IsNullOrEmpty(guildId))
        {
            return null;
        }

        return guildId switch
        {
            MockTestIds.TestGuildId1 => new GetGuildResponse
            {
                Guild = CreateMockGuild(MockTestIds.TestGuildId1, "Test Guild Alpha", 50)
            },
            MockTestIds.TestGuildId2 => new GetGuildResponse
            {
                Guild = CreateMockGuild(MockTestIds.TestGuildId2, "Test Guild Beta", 45)
            },
            _ => new GetGuildResponse { Guild = CreateMockGuild(guildId, "Unknown Guild", 10) }
        };
    }

    public static GetGuildsResponse GetGuildsResponse(GetGuildsRequestPayload? payload)
    {
        var guilds = new List<GuildProfile>
        {
            new()
            {
                Id = MockTestIds.TestGuildId1,
                Name = "Test Guild Alpha",
                MemberCount = 50
            },
            new()
            {
                Id = MockTestIds.TestGuildId2,
                Name = "Test Guild Beta",
                MemberCount = 45
            }
        };

        return new GetGuildsResponse
        {
            Guild = guilds,
            TotalRecords = guilds.Count
        };
    }

    private static Guild CreateMockGuild(string guildId, string name, int memberCount)
    {
        return new Guild
        {
            Profile = new GuildProfile
            {
                Id = guildId,
                Name = name,
                MemberCount = memberCount
            },
            Member = Enumerable.Range(1, Math.Min(memberCount, 5)).Select(i => new GuildMember
            {
                PlayerId = $"player-{i:D3}",
                PlayerName = $"Guild Member {i}",
                GalacticPower = 5000000
            }).ToList()
        };
    }
}