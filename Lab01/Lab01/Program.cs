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
            const double SunToNeptuneDistance = 4501000000;  // miles
            Console.WriteLine("SunToNeptuneDistance = {0} km", SunToNeptuneDistance * mileTokm);
            double SunToNeptuneTimeOfLight = SunToNeptuneDistance / lightSpeed;  // miles
            Console.WriteLine("SunToNeptuneTimeOfLight = {0} seconds", SunToNeptuneTimeOfLight);
            Console.WriteLine("SunToNeptuneTimeOfLight = {0} minutes", SunToNeptuneTimeOfLight / 60d);
            
        }
    }
}
