namespace BerlinClock.Model
{
    /// <summary>
    /// Data transfert object for a row of 4 lights.
    /// False, the light is switch off.
    /// True, the light is switch on.
    /// </summary>
    public class Row4LightsModel
    {
        public bool Light1 { get; set; }
        public bool Light2 { get; set; }
        public bool Light3 { get; set; }
        public bool Light4 { get; set; }        
    }
}