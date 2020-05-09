using BerlinClock.Model;
using System;

namespace BerlinClock.Api.Rows
{
    public abstract class Row4Lights : IRow4Lights
    {
        private int _actualValue = -1;

        public event Action<Row4LightsModel> OnRowChanged;

        public virtual void UpdateValue(int value)
        {
            if (this.OnRowChanged != null && _actualValue != value)                            
                this.OnRowChanged(ConvertValueToLights(value));            
        }

        internal Row4LightsModel ConvertValueToLights(int numberOfLights)
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
