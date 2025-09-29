using System.Collections.Concurrent;

namespace SessionCounter.Infrastructure;

public static class ApplicationState
{
    public static ConcurrentDictionary<string, DateTime> ActiveSessions { get; } = [];

    public static void RemoveNotActiveSessions()
    {
        foreach (var session in ActiveSessions)
        {
            if ((DateTime.Now - session.Value).Minutes > 0)
            {
                ActiveSessions.TryRemove(session.Key, out _);
            }
        }
    }
}
