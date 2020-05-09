using System;
using System.Threading;

namespace BerlinClock.Api
{
    public class SystemTimeApi : ISystemTimeApi
    {
        private Timer _timer;
        private TimeSpan _timeBetweenCustomAndNowTime;
        private int _actualSecond = -1;
        private int _actualMinute = -1;
        private int _actualHour = -1;

        public event Action<int> OnSecondChanged;
        public event Action<int> OnMinuteChanged;
        public event Action<int> OnHourChanged;
        public event Action<string> OnShortTimeUpdate;

        public void Start(int startHour, int startMinute)
        {
            DateTime now = DateTime.Now;
            _timeBetweenCustomAndNowTime = new TimeSpan(startHour - now.Hour, startMinute - now.Minute, 0);
            _timer = new Timer(TimerEverySecondCallback, null, 0, 1000);
            // Set the string time value            
            this.OnShortTimeUpdate(this.TimeString(startHour, startMinute));
        }

        public void Stop()
        {
            if (_timer != null)
                _timer.Dispose();
        }

        public void Dispose()
            => this.Stop();

        private string TimeString(int hour, int minute)
            => $"{hour.ToString("00")}:{minute.ToString("00")}";

        private void TimerEverySecondCallback(object obj)
        {
            DateTime time = DateTime.Now + _timeBetweenCustomAndNowTime;

            if (_actualSecond != time.Second)
            {
                _actualSecond = time.Second;
                this.OnSecondChanged?.Invoke(_actualSecond);
            }

            if (_actualMinute != time.Minute)
            {
                _actualMinute = time.Minute;
                this.OnMinuteChanged?.Invoke(_actualMinute);
                this.OnShortTimeUpdate(this.TimeString(time.Hour, time.Minute));
            }

            if (_actualHour != time.Hour)
            {
                _actualHour = time.Hour;
                this.OnHourChanged?.Invoke(_actualHour);
            }
        }
    }
}