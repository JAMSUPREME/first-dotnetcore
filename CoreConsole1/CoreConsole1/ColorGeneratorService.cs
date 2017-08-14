using System.Linq;

namespace CoreConsole1
{
    /// <summary>
    /// Can imagine this is a service we control and needs to be unit tested.
    /// </summary>
    public class ColorGeneratorService
    {
        private static readonly string[] AvailableColors = {
            "Red",
            "Green",
            "Blue",
            "Orange",
            "Black",
            "White",
            "Yellow"
        };
        
        public string[] GenerateColors(int size = 1, bool randomize = false)
        {
            return AvailableColors.Take(size).ToArray();
        }
    }
}