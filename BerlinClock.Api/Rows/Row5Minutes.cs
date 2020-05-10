using System;

namespace BerlinClock.Api.Rows
{
    /// <summary>
    /// Class to manage to third row of the Berlin clock
    /// </summary>
    public class Row5Minutes : Row11Lights
    {
        public override void UpdateValue(int minute)
        {
            if (minute < 0 || minute > 59)
                throw new ArgumentException("Minute argument should have a value between 0 and 59.");

            base.UpdateValue(minute / 5);
        }
    }
}