using BerlinClock.Model;
using System;

namespace BerlinClock.Api.Rows
{
    public class Row11Lights : IRow11Lights
    {
        private int _actualValue = -1;

        public event Action<Row11LightsModel> OnRowChanged;

        public virtual void UpdateValue(int value)
        {
            if (this.OnRowChanged != null && _actualValue != value)                            
                this.OnRowChanged(ConvertValueToLights(value));            
        }

        internal Row11LightsModel ConvertValueToLights(int numberOfLights)
        {
            if (numberOfLights < 1)
                return new Row11LightsModel();

            switch (numberOfLights)
            {
                case 1:
                    return new Row11LightsModel() { Light1 = true };
                case 2:
                    return new Row11LightsModel() { Light1 = true, Light2 = true };
                case 3:
                    return new Row11LightsModel() { Light1 = true, Light2 = true, Light3 = true };
                case 4:
                    return new Row11LightsModel() { Light1 = true, Light2 = true, Light3 = true, Light4 = true };
                case 5:
                    return new Row11LightsModel() { Light1 = true, Light2 = true, Light3 = true, Light4 = true, Light5 = true };
                case 6:
                    return new Row11LightsModel() { Light1 = true, Light2 = true, Light3 = true, Light4 = true, Light5 = true, Light6 = true };
                case 7:
                    return new Row11LightsModel() { Light1 = true, Light2 = true, Light3 = true, Light4 = true, Light5 = true, Light6 = true, Light7 = true };
                case 8:
                    return new Row11LightsModel() { Light1 = true, Light2 = true, Light3 = true, Light4 = true, Light5 = true, Light6 = true, Light7 = true, Light8 = true };
                case 9:
                    return new Row11LightsModel() { Light1 = true, Light2 = true, Light3 = true, Light4 = true, Light5 = true, Light6 = true, Light7 = true, Light8 = true, Light9 = true };
                case 10:
                    return new Row11LightsModel() { Light1 = true, Light2 = true, Light3 = true, Light4 = true, Light5 = true, Light6 = true, Light7 = true, Light8 = true, Light9 = true, Light10 = true };
                default:
                    return new Row11LightsModel() { Light1 = true, Light2 = true, Light3 = true, Light4 = true, Light5 = true, Light6 = true, Light7 = true, Light8 = true, Light9 = true, Light10 = true, Light11 = true };
            }
        }
    }
}
