using BerlinClock.Model;
using System;

namespace BerlinClock.Api
{
    /// <summary>
    /// Main interface to manage the entire Berlin clock
    /// </summary>
    public interface IBerlinClockApi : IDisposable
    {
        event Action<bool> OnOrangeLightVisible;
        event Action<string> OnShortTimeUpdated;
        event Action<Row4LightsModel> OnRow5HoursChanged;
        event Action<Row4LightsModel> OnRow1HourChanged;
        event Action<Row11LightsModel> OnRow5MinutesChanged;
        event Action<Row4LightsModel> OnRow1MinuteChanged;

        void Start(int hour, int minute);
        void Stop();
    }
}