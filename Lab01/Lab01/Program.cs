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
            const double SunToJupiterDistance = 778330000;  // miles
            Console.WriteLine("SunToJupiterDistance = {0} km", SunToJupiterDistance * mileTokm);
            double SunToJupiterTimeOfLight = SunToJupiterDistance / lightSpeed;  // miles
            Console.WriteLine("SunToJupiterTimeOfLight = {0} seconds", SunToJupiterTimeOfLight);
            Console.WriteLine("SunToJupiterTimeOfLight = {0} minutes", SunToJupiterTimeOfLight / 60d);
            
        }
    }
}
