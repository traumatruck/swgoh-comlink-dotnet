using SwgohComlink.Client.Models;
using SwgohComlink.Client.Models.Events;

namespace SwgohComlink.MockApi.SampleData;

/// <summary>
///     Provides mock data for event-related endpoints.
/// </summary>
public static class EventMockDataProvider
{
    public static GetEventsResponse GetEventsResponse()
    {
        return new GetEventsResponse
        {
            GameEvent =
            [
                new GameEvent
                {
                    Id = "event-001",
                    NameKey = "TEST_EVENT_ONE",
                    SummaryKey = "Test Event One Summary",
                    DescKey = "This is the first test event for mock API testing.",
                    Instance =
                    [
                        new GameEventInstance
                        {
                            Id = "instance-001",
                            StartTime = DateTimeOffset.UtcNow.AddDays(-1).ToUnixTimeMilliseconds(),
                            EndTime = DateTimeOffset.UtcNow.AddDays(6).ToUnixTimeMilliseconds()
                        }
                    ]
                },

                new GameEvent
                {
                    Id = "event-002",
                    NameKey = "TEST_EVENT_TWO",
                    SummaryKey = "Test Event Two Summary",
                    DescKey = "This is the second test event for mock API testing.",
                    Instance =
                    [
                        new GameEventInstance
                        {
                            Id = "instance-002",
                            StartTime = DateTimeOffset.UtcNow.AddDays(1).ToUnixTimeMilliseconds(),
                            EndTime = DateTimeOffset.UtcNow.AddDays(3).ToUnixTimeMilliseconds()
                        }
                    ]
                }
            ]
        };
    }
}