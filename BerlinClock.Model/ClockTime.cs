using System;

namespace BerlinClock.Model
{
    public class ClockTime : IComparable<ClockTime>
    {
        public ClockTime(DateTime dateTime)
        {
            Hour = dateTime.Hour;
            Minute = dateTime.Minute;
        }

        public ClockTime(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }

        public int Hour { get; private set; }
        public int Minute { get; private set; }

        //public static ClockTime operator + (ClockTime clockTime1, ClockTime clockTime2)
        //{
            
        //    return clockTime
        //}

        public int CompareTo(ClockTime other)
        {
            return (this.Hour * 60 + this.Minute) - (other.Hour * 60 + other.Minute);
        }
    }
}