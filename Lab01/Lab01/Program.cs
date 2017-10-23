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
            const double SunToPlutoDistance = 5945900000;  // miles
            Console.WriteLine("SunToPlutoDistance = {0} km", SunToPlutoDistance * mileTokm);
            double SunToPlutoTimeOfLight = SunToPlutoDistance / lightSpeed;  // miles
            Console.WriteLine("SunToPlutoTimeOfLight = {0} seconds", SunToPlutoTimeOfLight);
            Console.WriteLine("SunToPlutoTimeOfLight = {0} minutes", SunToPlutoTimeOfLight / 60d);
            
        }
    }
}
