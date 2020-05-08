using BerlinClock.Model;
using System;

namespace BerlinClock.Api
{
    public interface IBerlinClockApi : IDisposable
    {
        event Action<DateTime> OnUpdateBerlinClock;
        event Action<Row4LightsModel> OnRow5HoursChanged;
        event Action<Row4LightsModel> OnRow1HourChanged;
        event Action<Row11LightsModel> OnRow5MinutesChanged;
        event Action<Row4LightsModel> OnRow1MinuteChanged;

        void Start(int hour, int minute);
        void Stop();
    }
}