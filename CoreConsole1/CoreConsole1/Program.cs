using System;

namespace CoreConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            foreach (var color in new ColorGeneratorService().GenerateColors())
            {
                Console.WriteLine(color + " has personality "
                                  + new ColorPersonalityService().GetPersonality(color));
            }
        }
    }
}