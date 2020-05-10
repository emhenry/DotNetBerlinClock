namespace BerlinClock.Model
{
    /// <summary>
    /// Data transfert object for a row of 11 lights.
    /// False, the light is switch off.
    /// True, the light is switch on.
    /// </summary>
    public class Row11LightsModel : Row4LightsModel
    {
        public bool Light5 { get; set; }
        public bool Light6 { get; set; }
        public bool Light7 { get; set; }
        public bool Light8 { get; set; }
        public bool Light9 { get; set; }
        public bool Light10 { get; set; }
        public bool Light11 { get; set; }
    }
}