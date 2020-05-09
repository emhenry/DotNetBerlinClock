using System;

namespace BerlinClock.Api
{
    public interface ISystemTimeApi : IDisposable
    {
        event Action<int> OnHourChanged;
        event Action<int> OnMinuteChanged;
        event Action<int> OnSecondChanged;
        event Action<string> OnShortTimeUpdate;

        void Start(int startHour, int startMinute);
        void Stop();
    }
}