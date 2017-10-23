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
            const double SunToVenusDistance = 108200000;  // miles
            Console.WriteLine("SunToVenusDistance = {0} km", SunToVenusDistance * mileTokm);
            double SunToEarthTimeOfLight = SunToVenusDistance / lightSpeed;  // miles
            Console.WriteLine("SunToVenusTimeOfLight = {0} seconds", SunToEarthTimeOfLight);
            Console.WriteLine("SunToVenusTimeOfLight = {0} minutes", SunToEarthTimeOfLight / 60d);
            
        }
    }
}
