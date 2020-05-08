using BerlinClock.Model;
using System;

namespace BerlinClock.Api.Rows
{
    public interface IRow4Lights
    {
        event Action<Row4LightsModel> OnRowChanged;

        void UpdateValue(int value);
    }
}