using System;

namespace BerlinClock.Api.Rows
{
    public class Row5Hours : Row4Lights
    {
        public override void UpdateValue(int hour)
        {
            if (hour < 0 || hour > 24)
                throw new ArgumentException("Hour argument should have a value between 0 and 24.");

            base.UpdateValue(hour / 5);
        }        
    }
}