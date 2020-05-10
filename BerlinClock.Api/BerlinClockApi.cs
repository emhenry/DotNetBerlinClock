using BerlinClock.Api.Rows;
using System;
using BerlinClock.Model;

namespace BerlinClock.Api
{
    /// <summary>
    /// Main class to manage the entire Berlin clock
    /// </summary>
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

        #region Public Methods

        /// <summary>
        /// Start the Berlin clock with a custom initialisation of the time.
        /// </summary>
        /// <param name="startHour">Starting hour of the Berlin clock</param>
        /// <param name="startMinute">Starting minute of the Berlin clock</param>
        public void Start(int startHour, int startMinute)
            => _systemTimeApi.Start(startHour, startMinute);

        /// <summary>
        /// Stop the Berlin clock.
        /// </summary>
        public void Stop()
            => _systemTimeApi.Stop();

        /// <summary>
        /// Dispose the Berlin clock.
        /// </summary>
        public void Dispose()
            => _systemTimeApi.Dispose();
        #endregion

        #region Time Events

        /// <summary>
        /// Event to blink the yellow light.
        /// For an even number, the light is on.
        /// For a odd number, the light is off
        /// </summary>
        /// <param name="second">Second of the time</param>
        private void SecondChanged(int second)
         => OnOrangeLightVisible?.Invoke(second % 2 == 0);

        /// <summary>
        /// When the minute changed, we update the rows managing the minutes.
        /// </summary>
        /// <param name="minute">Minute of the time</param>
        private void MinuteChanged(int minute)
        {
            _row1Minute.UpdateValue(minute);
            _row5Minutes.UpdateValue(minute);
        }

        /// <summary>
        /// When the hour changed, we update the rows managing the hours.
        /// </summary>
        /// <param name="hour">Hour of the time</param>
        private void HourChanged(int hour)
        {
            _row1Hour.UpdateValue(hour);
            _row5Hours.UpdateValue(hour);
        }
        #endregion
    }
}