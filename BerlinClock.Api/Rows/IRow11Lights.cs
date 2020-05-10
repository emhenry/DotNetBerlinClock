using BerlinClock.Model;
using System;

namespace BerlinClock.Api.Rows
{
    /// <summary>
    /// Interface to manage a row of 11 lights
    /// </summary>
    public interface IRow11Lights
    {
        event Action<Row11LightsModel> OnRowChanged;

        void UpdateValue(int value);
    }
}