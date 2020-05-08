using System;

namespace BerlinClock.Api
{
    public interface IBerlinClockApi : IDisposable
    {
        void Start(int hour, int minute);
        void Stop();
    }
}