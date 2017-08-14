using System;

namespace CoreConsole1
{
    /// <summary>
    /// Will represent the "external service" dependency for integration tests.
    /// Can imagine this is an API.
    /// </summary>
    public class ColorPersonalityService
    {
        public string GetPersonality(string color)
        {
            switch (color)
            {
                case "Red":
                    return "Angry";
                case "Green":
                    return "Sick";
                case "Blue":
                    return "Depressed";
                case "Orange":
                    return "Energetic";
                default:
                    throw new ArgumentException("Color " + color + " is not supported");
            }
        }
    }
}