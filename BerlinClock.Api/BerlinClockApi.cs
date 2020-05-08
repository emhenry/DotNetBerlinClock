using BerlinClock.Api.Rows;
using System;
using System.Timers;
using BerlinClock.Model;

namespace BerlinClock.Api
{
    public class BerlinClockApi : IBerlinClockApi
    {
        public BerlinClockApi(IRow4Lights row5Hours, IRow4Lights row1Hour,
                                IRow11Lights row5Minutes, IRow4Lights row1Minute)
        {
            _row5Hours = row5Hours;
            _row1Hour = row1Hour;
            _row5Minutes = row5Minutes;
            _row1Minute = row1Minute;
            _timer = new Timer(_timeSpan);
            _timer.Elapsed += OnTimerElapsed;

            _row5Hours.OnRowChanged += (x) => this.OnRow5HoursChanged?.Invoke(x);
            _row1Hour.OnRowChanged += (x) => this.OnRow1HourChanged?.Invoke(x);
            _row5Minutes.OnRowChanged += (x) => this.OnRow5MinutesChanged?.Invoke(x);
            _row1Minute.OnRowChanged += (x) => this.OnRow1MinuteChanged?.Invoke(x);
        }
        
        private const int _timeSpan = 2000;

        private readonly IRow4Lights _row5Hours;
        private readonly IRow4Lights _row1Hour;
        private readonly IRow11Lights _row5Minutes;
        private readonly IRow4Lights _row1Minute;

        private Timer _timer;
        private TimeSpan _timeBetweenCustomAndNowTime;

        public event Action<DateTime> OnUpdateBerlinClock;
        public event Action<Row4LightsModel> OnRow5HoursChanged;
        public event Action<Row4LightsModel> OnRow1HourChanged;
        public event Action<Row11LightsModel> OnRow5MinutesChanged;
        public event Action<Row4LightsModel> OnRow1MinuteChanged;

        public void Start(int startHour, int startMinute)
        {
            DateTime now = DateTime.Now;
            _timeBetweenCustomAndNowTime = new TimeSpan(startHour - now.Hour, startMinute - now.Minute, 0);
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        public void Dispose()
        {
            _timer.Dispose();
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            this.UpdateBerlinClock();
        }

        private void UpdateBerlinClock()
        {
            DateTime time = DateTime.Now + _timeBetweenCustomAndNowTime;
            _row5Hours.UpdateValue(time.Hour);
            _row1Hour.UpdateValue(time.Hour);
            _row5Minutes.UpdateValue(time.Minute);
            _row1Minute.UpdateValue(time.Minute);
            this.OnUpdateBerlinClock?.Invoke(time);
        }
    }
}
