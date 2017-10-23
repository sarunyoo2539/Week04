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
            const double SunToUranusDistance = 2873550000;  // miles
            Console.WriteLine("SunToUranusDistance = {0} km", SunToUranusDistance * mileTokm);
            double SunToUranusTimeOfLight = SunToUranusDistance / lightSpeed;  // miles
            Console.WriteLine("SunToUranusTimeOfLight = {0} seconds", SunToUranusTimeOfLight);
            Console.WriteLine("SunToUranusTimeOfLight = {0} minutes", SunToUranusTimeOfLight / 60d);
            
        }
    }
}
