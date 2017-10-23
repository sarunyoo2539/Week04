using System;
namespace variableProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            const double lightSpeed = 186000d;   // miles per second
            Console.WriteLine("Light speed = {0} Mile Per second", lightSpeed);
            const double mileTokm = 1.609344;
            Console.WriteLine("Light speed = {0} km Per second", lightSpeed * mileTokm);
            const double SunToMercuryDistance = 57910000;  // miles
            Console.WriteLine("SunToMercuryDistance = {0} km", SunToMercuryDistance * mileTokm);
            double SunToEarthTimeOfLight = SunToMercuryDistance / lightSpeed;  // miles
            Console.WriteLine("SunToMercuryTimeOfLight = {0} seconds", SunToEarthTimeOfLight);
            Console.WriteLine("SunToMercuryTimeOfLight = {0} minutes", SunToEarthTimeOfLight / 60d);
            
        }
    }
}
