using BerlinClock.Model;
using System;

namespace BerlinClock.Api.Rows
{
    public interface IRow11Lights
    {
        event Action<Row11LightsModel> OnRowChanged;

        void UpdateValue(int value);
    }
}