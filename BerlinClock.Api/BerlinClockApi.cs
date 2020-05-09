using BerlinClock.Api.Rows;
using System;
using BerlinClock.Model;

namespace BerlinClock.Api
{
    public class BerlinClockApi : IBerlinClockApi
    {
        public BerlinClockApi(IRow4Lights row5Hours, IRow4Lights row1Hour,
                    IRow11Lights row5Minutes, IRow4Lights row1Minute, ISystemTimeApi systemTimeApi)
        {
            // Implementations
            _row5Hours = row5Hours;
            _row1Hour = row1Hour;
            _row5Minutes = row5Minutes;
            _row1Minute = row1Minute;
            _systemTimeApi = systemTimeApi;
            // Row events
            _row5Hours.OnRowChanged += (x) => this.OnRow5HoursChanged?.Invoke(x);
            _row1Hour.OnRowChanged += (x) => this.OnRow1HourChanged?.Invoke(x);
            _row5Minutes.OnRowChanged += (x) => this.OnRow5MinutesChanged?.Invoke(x);
            _row1Minute.OnRowChanged += (x) => this.OnRow1MinuteChanged?.Invoke(x);
            // Time events
            _systemTimeApi.OnShortTimeUpdate += (x) => this.OnShortTimeUpdated?.Invoke(x);
            _systemTimeApi.OnSecondChanged += SecondChanged;
            _systemTimeApi.OnMinuteChanged += MinuteChanged;
            _systemTimeApi.OnHourChanged += HourChanged;
        }

        private readonly IRow4Lights _row5Hours;
        private readonly IRow4Lights _row1Hour;
        private readonly IRow11Lights _row5Minutes;
        private readonly IRow4Lights _row1Minute;
        private readonly ISystemTimeApi _systemTimeApi;

        public event Action<bool> OnOrangeLightVisible;
        public event Action<string> OnShortTimeUpdated;
        public event Action<Row4LightsModel> OnRow5HoursChanged;
        public event Action<Row4LightsModel> OnRow1HourChanged;
        public event Action<Row11LightsModel> OnRow5MinutesChanged;
        public event Action<Row4LightsModel> OnRow1MinuteChanged;

        public void Start(int startHour, int startMinute)
            => _systemTimeApi.Start(startHour, startMinute);

        public void Stop()
            => _systemTimeApi.Stop();

        public void Dispose()
            => _systemTimeApi.Dispose();

        #region Time Events

        private void SecondChanged(int second)
         => OnOrangeLightVisible?.Invoke(second % 2 == 0);

        private void MinuteChanged(int minute)
        {
            _row1Minute.UpdateValue(minute);
            _row5Minutes.UpdateValue(minute);
        }

        private void HourChanged(int hour)
        {
            _row1Hour.UpdateValue(hour);
            _row5Hours.UpdateValue(hour);
        }
        #endregion
    }
}