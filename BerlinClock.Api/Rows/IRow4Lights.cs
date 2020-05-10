using BerlinClock.Model;
using System;

namespace BerlinClock.Api.Rows
{
    /// <summary>
    /// Interface to manage a row of 4 lights
    /// </summary>
    public interface IRow4Lights
    {
        event Action<Row4LightsModel> OnRowChanged;

        void UpdateValue(int value);
    }
}