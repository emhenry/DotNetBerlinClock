using BerlinClock.Model;
using System;

namespace BerlinClock.Api.Rows
{
    /// <summary>
    /// Base class to manage a row of 4 lights
    /// </summary>
    public abstract class Row4Lights : IRow4Lights
    {
        private int _actualValue = -1;

        public event Action<Row4LightsModel> OnRowChanged;

        /// <summary>
        /// Method which trigger an event if the value changed.
        /// If the value does not changed, nothing happens.
        /// </summary>
        /// <param name="value">Value</param>
        public virtual void UpdateValue(int value)
        {
            if (this.OnRowChanged != null && _actualValue != value)                            
                this.OnRowChanged(ConvertValueToLights(value));            
        }

        /// <summary>
        /// Create model of the lights state.
        /// </summary>
        /// <param name="numberOfLights">Number of lights to switch on</param>
        /// <returns>Data model with the state of the lights</returns>
        private Row4LightsModel ConvertValueToLights(int numberOfLights)
        {
            if (numberOfLights < 1)
                return new Row4LightsModel();

            switch (numberOfLights)
            {                
                case 1:
                    return new Row4LightsModel() { Light1 = true };
                case 2:
                    return new Row4LightsModel() { Light1 = true, Light2 = true };
                case 3:
                    return new Row4LightsModel() { Light1 = true, Light2 = true, Light3 = true };
                default:
                    return new Row4LightsModel() { Light1 = true, Light2 = true, Light3 = true, Light4 = true };
            }
        }
    }
}